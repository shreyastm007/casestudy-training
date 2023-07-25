using Microsoft.AspNetCore.Mvc;
using StudyCaseIntegrate.Model;
using StudyCaseIntegrate.Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web.Http.Cors;

namespace StudyCaseIntegrate.Controllers
{
   
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        [ApiController]
        [Route("[Controller]")]
    public class ProductController : ControllerBase
    {

        public readonly IProductRepository _productRepository;
            public ProductController(IProductRepository productRepository) {
            _productRepository = productRepository;
            }


            [HttpGet]
            [Route("Product/Get")]
            public IEnumerable<Product> GetProduct() {
                return _productRepository.GetAllProduct();
            }



            [HttpGet]
            [Route("Product/Get/{id}")]
            public Product GetProductById(int ProductId) {
                return _productRepository.GetProduct(ProductId);
            }


            [HttpPost]
            [Route("Product/Post")]
            public Product AddProduct(Product product) {
                var newproduct = _productRepository.Add(product);
                return newproduct;
            } //hardcoded so not executable


            [HttpDelete]
            [Route("Product/Delete/{id}")]
            public Product DeleteProduct(int id) {
                var deleteproduct = _productRepository.Delete(id);
                return deleteproduct;
            }


        }
    }
