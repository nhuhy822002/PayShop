using PayShop.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace PayShop.Infrastructure
{
    public class PayShopContext : IdentityDbContext<AppUser>//them login trong migration
    {
        public PayShopContext(DbContextOptions<PayShopContext> options)
           : base(options)
        {

        }
        public DbSet<Page> Pages { get; set; } //Trang
        public DbSet<Category> Categories { get; set; } //Danh mục
        public DbSet<Product> Products { get; set; } //Sản phẩm
    }
}

