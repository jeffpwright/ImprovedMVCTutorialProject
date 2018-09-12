using DomainInterfaces.Factories;
using ProductsApp.Interfaces.DomainInterfaces;

namespace ProductsApp.Domain.ProductsAppDomain.ModelFactories
{
    public class ModelFactory : IModelFactory
    {
        public IProduct CreateProduct()
        {
            return new Product();
        }

        public IProduct CreateProduct(int id, string name, string category, decimal price)
        {
            return new Product { Id = id, Category = category, Name = name, Price = price };
        }
    }
}
