using StudyCaseIntegrate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.Repository
{
    public interface IProductRepository
    {
        Product GetProduct(int ProductId);
        IEnumerable<Product> GetAllProduct();
        Product Add(Product product);
        Product Update(Product product);
        Product Delete(int ProductId);
    }
}
