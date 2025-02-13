
using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.Abstracts;
using EccomerceApiCleanArchitecture.Service.Abstracts;

namespace EccomerceApiCleanArchitecture.Service.Implemtations

{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllProductsAsync();
        }
    }
}
