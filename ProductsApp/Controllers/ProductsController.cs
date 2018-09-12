using ProductsApp.Interfaces;
using ProductsApp.Interfaces.DomainInterfaces;
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using ProductsApp.Domain.ProductsAppDomain;

namespace ProductsApp.Controllers
{
    public class ProductsController : ApiController
    {
        private readonly IProductsAppApplication _application;

        public ProductsController(IProductsAppApplication application)
        {
            _application = application;
        }

        public IEnumerable<IProduct> GetAllProducts() => _application.GetAllProducts();

        public IHttpActionResult GetProduct(int id)
        {
            var model = _application.GetProduct(id);
            var contract = new Product();

            Mapper.Map(model, contract);
            
            return Ok(contract);
        }
    }
}