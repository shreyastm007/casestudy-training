using StudyCaseIntegrate.Model;
using StudyCaseIntegrate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StudyCaseIntegrate.services
{
    public class SqlCartRepository : IcartRepository
    {

        public readonly CartDbContext context;
        public SqlCartRepository(CartDbContext context) {
            this.context = context;
        }

        public Cart Add(Cart cart) {
            context.Add(cart);
            context.SaveChanges();
            return cart;
        }

        public Cart Delete(int CartId) {
            Cart cart = context.cart.Find(CartId);
            if (cart != null) {
                context.cart.Remove(cart);
                context.SaveChanges();
            }
            return cart;
        }

        public IEnumerable<Cart> GetAllCart() {
            return context.cart;
        }

        public Cart GetCart(int CartId) {
            return context.cart.Find(CartId);
        }

        public Cart Update(Cart CartDbContext) {
            var cart = context.cart.Attach(CartDbContext);
            //attach method returns the entity entry of employee type. so the ef needs to know that the entry we attached is modified to do that.
            cart.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            context.SaveChanges();
            return CartDbContext;

        }
    }
}

