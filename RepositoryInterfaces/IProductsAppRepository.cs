using ProductsApp.Interfaces.DomainInterfaces;
using System.Collections.Generic;

namespace RepositoryInterfaces
{
    public interface IProductsAppRepository
    {
        IEnumerable<IProduct> GetAllProducts();
        IProduct GetProduct(int id);
    }
}
