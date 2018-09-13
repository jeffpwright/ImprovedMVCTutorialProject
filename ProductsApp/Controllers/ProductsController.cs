using ProductsApp.Interfaces;
using ProductsApp.Interfaces.DomainInterfaces;
using System.Collections.Generic;
using System.Web.Http;
using AutoMapper;
using ProductsApp.Domain.ProductsAppDomain;
using System;

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
            Product contract = null;
            IHttpActionResult result;

            try
            {
                var model = _application.GetProduct(id);
                contract = new Product();
                Mapper.Map(model, contract);
                result = Ok(contract);
            }
            catch (Exception ex)
            {
                if (ex.Message.Contains("not found"))
                {
                    result = NotFound();
                }
                else
                {
                    result = InternalServerError();
                }
            }

            return result;
        }
    }
}