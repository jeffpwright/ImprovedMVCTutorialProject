using ProductsApp.Contracts;
using ProductsApp.Interfaces.DomainInterfaces;

namespace ProductsApp.Infrastructure
{
    public class AutomapperWebProfile : AutoMapper.Profile
    {
        public AutomapperWebProfile()
        {
            CreateMap<IProduct, ProductReturnContract>();
        }

        public static void Run() => AutoMapper.Mapper.Initialize(a => a.AddProfile<AutomapperWebProfile>());
    }
}