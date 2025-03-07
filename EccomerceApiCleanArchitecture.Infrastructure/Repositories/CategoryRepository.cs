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
    public class CategoryRepository : ICategoryRepository
    {
        private readonly ApplicationDbContext _applicationDbContext;

        public CategoryRepository(ApplicationDbContext applicationDbContext)
        {
            _applicationDbContext = applicationDbContext;
        }
        public async Task<Category> AddNewCategory(Category category)
        {
             _applicationDbContext.Categories.Add(category);
            await _applicationDbContext.SaveChangesAsync();
            return category;
        }

        public async Task<List<Category>> GetAllCategoriesAsync()
        {
           return await _applicationDbContext.Categories.ToListAsync();
        }
    }
}
