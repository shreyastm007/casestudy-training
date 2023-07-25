using Microsoft.EntityFrameworkCore;
using StudyCaseIntegrate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.services
{
    public class CartDbContext : DbContext
    {
            public CartDbContext(DbContextOptions<CartDbContext> options) : base(options) {

            }
            //only one type is present in our project as of now
            public DbSet<Cart> cart { get; set; }

        }
    }
