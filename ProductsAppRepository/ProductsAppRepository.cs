using DomainInterfaces.Factories;
using ProductsApp.Interfaces.DomainInterfaces;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;

namespace ProductsAppRepository
{
    public class ProductsAppRepository : IProductsAppRepository
    {
        private readonly IEnumerable<IProduct> _products;

        public ProductsAppRepository(IModelFactory modelFactory)
        {
            _products = new List<IProduct>{
                modelFactory.CreateProduct(1, "Tomato Soup", "Grocery", 1),
                modelFactory.CreateProduct(2, "Yo-yo", "Toys", 3.75M),
                modelFactory.CreateProduct(3, "Hammer", "Hardware", 16.99M)
            };
        }
        
        public IEnumerable<IProduct> GetAllProducts()
        {
            return _products;
        }

        public IProduct GetProduct(int id)
        {
            var product = _products.FirstOrDefault((p) => p.Id == id);
            if (product == null)
            {
                throw new Exception("Product not found");
            }

            return product;
        }
    }
}
