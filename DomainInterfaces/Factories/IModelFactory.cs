using ProductsApp.Interfaces.DomainInterfaces;

namespace DomainInterfaces.Factories
{
    public interface IModelFactory
    {
        IProduct CreateProduct();
        IProduct CreateProduct(int id, string name, string category, decimal price);
    }
}
