using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.InfrastructureBase;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure.Abstracts
{
    public interface IProductRepository:IGenericRepositoryAsync<Product>
    {
       
        //Task<Product> GetProductByNameAsync(string name);

    }
}
