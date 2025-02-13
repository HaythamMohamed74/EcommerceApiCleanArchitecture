using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.Abstracts;
using EccomerceApiCleanArchitecture.Infrastructure.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public ProductRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<List<Product>> GetAllProductsAsync()
        {
            return await _applicationDbContext.Products.ToListAsync();
        }
    }
}
