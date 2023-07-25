using Microsoft.EntityFrameworkCore;
using StudyCaseIntegrate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.services
{
    public class ProductDbContext : DbContext
    {

            public ProductDbContext(DbContextOptions<ProductDbContext> options) : base(options) {

            }
            //only one type is present in our project as of now
            public DbSet<Product> product { get; set; }

        }
    }

