using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features._Categories.Command.Model;
using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features._Categories.Command.Handler
{
    public class CreateNewCategoryCommandHandler :ResponseHandler,
      IRequestHandler<CreateNewCategoryCommand, Response<int>>
    {
        private readonly ICategoryService _categoryService;

        public CreateNewCategoryCommandHandler(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }
        public async Task<Response<int>>Handle(CreateNewCategoryCommand request, CancellationToken cancellationToken)
        {
            
            var category = new Category
            {
                Name = request.Name,
                IsActive = request.IsActive,
                Description = request.Desc,
                CreatedAt = DateTime.Now,
                IsDeleted = false

            };
           await  _categoryService.AddNewCategory(category);
            return Created(category.Id);
            

        }

        
    }
}
