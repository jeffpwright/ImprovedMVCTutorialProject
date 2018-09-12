using ProductsApp.Interfaces.DomainInterfaces;
using System.Collections.Generic;

namespace ProductsApp.Interfaces
{
    public interface IProductsAppApplication
    {
        IEnumerable<IProduct> GetAllProducts();
        IProduct GetProduct(int id);
    }
}
