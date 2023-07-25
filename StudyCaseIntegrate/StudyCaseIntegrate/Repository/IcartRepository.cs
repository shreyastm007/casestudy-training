using StudyCaseIntegrate.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.Repository
{
    public interface IcartRepository
    {
        Cart GetCart(int CartId);
        IEnumerable<Cart> GetAllCart();
        Cart Add(Cart cart);
        Cart Update(Cart cart);
        Cart Delete(int CartId);
    }
}
