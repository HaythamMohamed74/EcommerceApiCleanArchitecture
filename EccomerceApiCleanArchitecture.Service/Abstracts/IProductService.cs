

using EccomerceApiCleanArchitecture.Data.Entities;

namespace EccomerceApiCleanArchitecture.Service.Abstracts
{
    public interface IProductService
    {
        Task<ICollection<Product>> GetAllProductsAsync();

        Task <Product>AddNewProduct(Product product);

        Task<Product> GetProductByIdAsync(int id);

        Task<Product> UpdateProduct(Product product);

        Task<List<Product>>GetProductsByNameAsync(string name);
    }
}
