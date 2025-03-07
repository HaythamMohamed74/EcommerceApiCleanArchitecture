using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Infrastructure.Abstracts;
using EccomerceApiCleanArchitecture.Infrastructure.Context;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Service.Implemtations
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;

        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public async Task<Category> AddNewCategory(Category category)
        {
            
            return await  _categoryRepository.AddNewCategory(category);   
        }

        public Task<List<Category>> GetAllCategoriesAsync()
        {
            throw new NotImplementedException();
        }
    }
}
