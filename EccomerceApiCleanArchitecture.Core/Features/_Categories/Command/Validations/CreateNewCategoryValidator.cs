using EccomerceApiCleanArchitecture.Core.Features._Categories.Command.Model;
using FluentValidation;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features._Categories.Command.Validations
{
    public class CreateNewCategoryValidator:AbstractValidator<CreateNewCategoryCommand>
    {
        public CreateNewCategoryValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Category Name is required");
            RuleFor(x => x.IsActive).NotEmpty().WithMessage("Category status is required");
            RuleFor(x => x.Desc).MaximumLength(500).WithMessage("Description cannot exceed 500 characters"); ;
        }
    }
}
