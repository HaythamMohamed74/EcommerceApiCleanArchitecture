using EccomerceApiCleanArchitecture.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Infrastructure.Abstracts
{
    public interface IProductRepository
    {
       Task <List<Product>> GetAllProductsAsync();
    }
}
