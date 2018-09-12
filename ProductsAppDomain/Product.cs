using ProductsApp.Interfaces.DomainInterfaces;

namespace ProductsApp.Domain.ProductsAppDomain
{
    public class Product : IProduct
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Category { get; set; }
        public decimal Price { get; set; }
    }
}
