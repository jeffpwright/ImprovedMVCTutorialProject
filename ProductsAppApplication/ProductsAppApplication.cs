using ProductsApp.Interfaces;
using ProductsApp.Interfaces.DomainInterfaces;
using RepositoryInterfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProductsAppApplication
{
    public sealed class ProductsAppApplication : IProductsAppApplication
    {
        private readonly IProductsAppRepository _repository;

        public ProductsAppApplication(IProductsAppRepository repository)
        {
            _repository = repository;
        }

        public IEnumerable<IProduct> GetAllProducts() => _repository.GetAllProducts();

        public IProduct GetProduct(int id)
        {
            return _repository.GetProduct(id);

        }
    }
}
