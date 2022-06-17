using HighShopping.Infrastructure;
using HighShopping.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Areas.Admin.Controllers
{
    [Authorize(Roles = "admin,editor")]
    [Area("Admin")]
    public class CategoriesController : Controller
    {
        private readonly HighShoppingCartContext _context;
        public CategoriesController(HighShoppingCartContext context)
        {
            _context = context;
        }

        // GET /admin/categories
        public async Task<IActionResult> Index()
        {
            return View(await _context.Categories.OrderBy(x=>x.Sorting).ToListAsync());
        }

        // GET /admin/categories/create
        public IActionResult Create() => View();

        // POST /admin/categories/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Category category)
        {
            if (ModelState.IsValid)
            {
                category.Slug = category.Name.ToLower().Replace(" ", "-");
                category.Sorting = 100;

                var slug = await _context.Categories.FirstOrDefaultAsync(c => c.Slug == category.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "Danh mục đã tồn tại");
                    return View(category);
                }
                _context.Add(category);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Thêm danh mục thành công!";

                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET /admin/categories/edit/id
        public async Task<IActionResult> Edit(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }

            return View(category);
        }

        // POST /admin/category/edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(int id, Category category)
        {
            if (ModelState.IsValid)
            {
                category.Slug = category.Name.ToLower().Replace(" ", "-");

                var slug = await _context.Categories.Where(x => x.Id != id).FirstOrDefaultAsync(c => c.Slug == category.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "Danh mục đã tồn tại");
                    return View(category);
                }
                _context.Update(category);
                await _context.SaveChangesAsync();
                TempData["Success"] = "Sửa danh mục thành công!";

                return RedirectToAction("Index");
            }
            return View(category);
        }

        // GET /admin/categories/delete/id
        public async Task<IActionResult> Delete(int id)
        {
            Category category = await _context.Categories.FindAsync(id);
            if (category == null)
            {
                return NotFound();
            }
            else
            {
                _context.Categories.Remove(category);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Xóa danh mục thành công!";
            }

            return RedirectToAction("Index");
        }

        // POST /admin/categories/reorder
        [HttpPost]
        public async Task<IActionResult> Reorder(int[] id)
        {
            int count = 1;

            foreach (var categoryId in id)
            {
                Category category = await _context.Categories.FindAsync(categoryId);
                category.Sorting = count;
                _context.Update(category);
                await _context.SaveChangesAsync();
                count++;
            }
            return Ok();
        }
    }
}
