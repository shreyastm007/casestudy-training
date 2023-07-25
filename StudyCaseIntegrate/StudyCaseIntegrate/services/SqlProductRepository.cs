using StudyCaseIntegrate.Model;
using StudyCaseIntegrate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.services
{
        public class SqlProductRepository : IProductRepository
    {

            public readonly ProductDbContext context;
            public SqlProductRepository(ProductDbContext context) {
                this.context = context;
            }

            public Product Add(Product product) {
                context.Add(product);
                context.SaveChanges();
                return product;
            }

            public Product Delete(int ProductId) {
            Product product = context.product.Find(ProductId);
                if (product != null) {
                    context.product.Remove(product);
                    context.SaveChanges();
                }
                return product;
            }

            public IEnumerable<Product> GetAllProduct() {
                return context.product;
            }

            public Product GetProduct(int ProductId) {
                return context.product.Find(ProductId);
            }

            public Product Update(Product ProductDbContext) {
                var product = context.product.Attach(ProductDbContext);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            product.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
                context.SaveChanges();
                return ProductDbContext;

            }
        }
    }
