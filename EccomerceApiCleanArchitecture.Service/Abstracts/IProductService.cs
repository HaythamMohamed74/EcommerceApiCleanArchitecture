

using EccomerceApiCleanArchitecture.Data.Entities;

namespace EccomerceApiCleanArchitecture.Service.Abstracts
{
    public interface IProductService
    {
        Task<List<Product>> GetAllProductsAsync();
    }
}
