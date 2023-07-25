using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using ProductCart.Models;

namespace ProductCart.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options) {
        }
        public DbSet<ProductCart.Models.Cart> Cart { get; set; }
        public DbSet<ProductCart.Models.Product> Product { get; set; }
    }
}
