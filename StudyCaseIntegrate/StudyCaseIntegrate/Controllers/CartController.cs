using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;
using StudyCaseIntegrate.Repository;
using StudyCaseIntegrate.Model;

namespace StudyCaseIntegrate.Controllers
{
   
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [ApiController]
        [Route("[Controller]")]
    public class CartController : ControllerBase
    {

        public readonly IcartRepository _cartRepository;
            public CartController(IcartRepository cartRepository) {
            _cartRepository = cartRepository;
            }


            [HttpGet]
            [Route("Cart/Get")]
            public IEnumerable<Cart> GetCart() {
            return _cartRepository.GetAllCart();
            }



            [HttpGet]
            [Route("Cart/Get/{id}")]
            public Cart GetCartById(int CartId) {
            return _cartRepository.GetCart(CartId);
            }


            [HttpPost]
            [Route("Cart/Post")]
            public Cart AddCart(Cart cart) {
                var newcart = _cartRepository.Add(cart);
                return newcart;
            } //hardcoded so not executable


            [HttpDelete]
            [Route("Cart/Delete/{id}")]
            public Cart DeleteCart(int id) {
                var deletecart = _cartRepository.Delete(id);
                return deletecart;
            }


        }
    }


