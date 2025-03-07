using EccomerceApiCleanArchitecture.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Service.Abstracts
{
    public interface ICategoryService
    {
         Task<List<Category>> GetAllCategoriesAsync();

         Task<Category> AddNewCategory(Category category);
    }
}
