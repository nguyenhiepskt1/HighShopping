﻿using HighShopping.Infrastructure;
using HighShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Controllers
{
    public class ProductsController : Controller
    {
        private readonly HighShoppingCartContext _context;
        public ProductsController(HighShoppingCartContext context)
        {
            _context = context;
        }

        [Route("/products")]
        // GET /products
        public async Task<IActionResult> Index(int p = 1)
        {
            int pageSize = 6;
            var product = _context.Products.OrderByDescending(x => x.Id).Skip((p - 1) * pageSize).Take(pageSize);

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Products.Count() / pageSize);

            return View(await product.ToListAsync());
        }

        // GET /products/category
        public async Task<IActionResult> ProductsByCategory(string categorySlug, int p = 1)
        {
            Category category = await _context.Categories.Where(x => x.Slug == categorySlug).FirstOrDefaultAsync();
            if (category == null)
            {
                 RedirectToAction("Index");
            }
            int pageSize = 6;
            var product = _context.Products.OrderByDescending(x => x.Id)
                .Where(x => x.CategoryId == category.Id)
                .Skip((p - 1) * pageSize)
                .Take(pageSize);

            ViewBag.PageNumber = p;
            ViewBag.PageRange = pageSize;
            ViewBag.TotalPages = (int)Math.Ceiling((decimal)_context.Products.Where(x => x.CategoryId == category.Id).Count() / pageSize);
            ViewBag.CategoryName = category.Name;
            ViewBag.CategorySlug = categorySlug;

            return View(await product.ToListAsync());
        }
    }
}
