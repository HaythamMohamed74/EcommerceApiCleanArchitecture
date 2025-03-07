
using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.Abstracts;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using Microsoft.EntityFrameworkCore;

namespace EccomerceApiCleanArchitecture.Service.Implemtations

{
    public class ProductService:IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }

        public async Task<Product> AddNewProduct(Product product)
        {
         return  await  _productRepository.AddAsync(product);
        }

        public async Task<ICollection<Product>> GetAllProductsAsync()
        {
            return await _productRepository.GetAllAsync();
        }

        public async Task<Product> GetProductByIdAsync(int id)
        {
         return await   _productRepository.GetByIdAsync(id);
        }

        public async Task<List<Product>> GetProductsByNameAsync(string name)
        {
        var result=  await _productRepository.GetAsNoTracking().Include(p=>p.ProductImages)
                .Where(x => x.Name.Equals(name)).ToListAsync();
            return result;

        }

   
        public Task<Product> UpdateProduct(Product product)
        {
           _productRepository.UpdateAsync(product);
            return Task.FromResult(product);
        }
    }
}
