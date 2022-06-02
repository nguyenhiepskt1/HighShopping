using HighShopping.Infrastructure;
using HighShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PagesController : Controller
    {
        private readonly HighShoppingCartContext _context;
        public PagesController(HighShoppingCartContext context)
        {
            _context = context;
        }

        // GET /admin/pages
        public async Task<IActionResult> Index()
        {
            IQueryable<Page> pages = from p in _context.Pages orderby p.Sorting select p;

            List<Page> pagesList = await pages.ToListAsync();

            return View(pagesList);
        }

        // GET details/id
        public async Task<IActionResult> Details(int id)
        {
            Page page = await _context.Pages.FirstOrDefaultAsync(x => x.Id == id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // GET /create
        public IActionResult Create() => View();

        // POST /create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create(Page page)
        {
            if (ModelState.IsValid)
            {
                page.Slug = page.Title.ToLower().Replace(" ", "-");
                page.Sorting = 100;

                var slug = await _context.Pages.FirstOrDefaultAsync(c => c.Slug == page.Slug);
                if(slug != null)
                {
                    ModelState.AddModelError("", "Trang đã tồn tại");
                    return View(page);
                }
                _context.Add(page);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Thêm trang thành công!";

                return RedirectToAction("Index");
            }
            return View(page);
        }

        // GET edit/id
        public async Task<IActionResult> Edit(int id)
        {
            Page page = await _context.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }

            return View(page);
        }

        // POST /edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Page page)
        {
            if (ModelState.IsValid)
            {
                page.Slug = page.Id == 1 ? "home" : page.Title.ToLower().Replace(" ", "-");

                var slug = await _context.Pages.Where(x=>x.Id != page.Id).FirstOrDefaultAsync(c => c.Slug == page.Slug);
                if (slug != null)
                {
                    ModelState.AddModelError("", "Trang đã tồn tại");
                    return View(page);
                }
                _context.Update(page);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Sửa trang thành công!";

                return RedirectToAction("Index");
            }
            return View(page);
        }

        // GET delete/id
        public async Task<IActionResult> Delete(int id)
        {
            Page page = await _context.Pages.FindAsync(id);
            if (page == null)
            {
                return NotFound();
            }
            else
            {
                _context.Pages.Remove(page);
                await _context.SaveChangesAsync();

                TempData["Success"] = "Xóa trang thành công!";
            }

            return RedirectToAction("Index");
        }
    }
}
