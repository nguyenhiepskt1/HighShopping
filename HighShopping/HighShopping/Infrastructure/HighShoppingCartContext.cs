using HighShopping.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace HighShopping.Infrastructure
{
    public class HighShoppingCartContext : IdentityDbContext<AppUser>
    {
        public HighShoppingCartContext(DbContextOptions<HighShoppingCartContext> options) : base(options)
        {
        }

        public DbSet<Page> Pages { get; set; }
        public DbSet<Category> Categories { get; set; }
        public DbSet<Product> Products { get; set; }       
    }
}
