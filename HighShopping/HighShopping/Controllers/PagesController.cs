using HighShopping.Infrastructure;
using HighShopping.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Controllers
{
    public class PagesController : Controller
    {
        private readonly HighShoppingCartContext _context;
        public PagesController(HighShoppingCartContext context)
        {
            _context = context;
        }

        // GET / or /slug
        public async Task<IActionResult> Page(string slug)
        {
            if(slug == null)
            {
                return View(await _context.Pages.Where(x => x.Slug == "home").FirstOrDefaultAsync());
            }

            Page page = await _context.Pages.Where(x => x.Slug == slug).FirstOrDefaultAsync();

            if(page == null)
            {
                return NotFound();
            }

            return View(page);
        }
    }
}
