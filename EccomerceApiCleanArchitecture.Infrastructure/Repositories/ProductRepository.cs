using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.Abstracts;
using EccomerceApiCleanArchitecture.Infrastructure.Context;
using EccomerceApiCleanArchitecture.Infrastructure.InfrastructureBase;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure.Repositories
{
    public class ProductRepository : GenericRepositoryAsync<Product>, IProductRepository
    {
        private readonly    DbSet<Product> products;

        public ProductRepository(ApplicationDbContext applicationDbContext) : base(applicationDbContext)
        {
            products = applicationDbContext.Set<Product>();
        }

        //public async Task<Product> GetProductByNameAsync(string name)
        //{
        //var result=  await products.Where(x => x.Name.Contains(name)).FirstOrDefaultAsync();
        //    return result;
        //}

        //Handle Specific Methods
    }
}
