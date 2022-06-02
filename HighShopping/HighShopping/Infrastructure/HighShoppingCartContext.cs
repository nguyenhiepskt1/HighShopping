using HighShopping.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Infrastructure
{
    public class HighShoppingCartContext : DbContext
    {
        public HighShoppingCartContext(DbContextOptions<HighShoppingCartContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Page>().HasData(
                    new Page
                    {
                        Id = 1,
                        Title = "Trang chủ",
                        Slug = "home",
                        Content = "home page",
                        Sorting = 0
                    },
                    new Page
                    {
                        Id = 2,
                        Title = "Về chúng tôi",
                        Slug = "about-us",
                        Content = "about us page",
                        Sorting = 100
                    },
                    new Page
                    {
                        Id = 3,
                        Title = "Liên hệ",
                        Slug = "contact",
                        Content = "contact page",
                        Sorting = 100
                    }
                );
        }
    }
}
