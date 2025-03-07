using EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Validations
{
    class EditProductValidator:AbstractValidator<EditProductCommand>
    {
        public EditProductValidator()
        {
            RuleFor(x => x.Id).NotEmpty().WithMessage("Id Is required");
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name Is Requird");
            RuleFor(x => x.Desc).NotEmpty();
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price must be greater than zero.");
            RuleFor(x => x.StockQuantity).GreaterThanOrEqualTo(0).WithMessage("Stock cannot be negative.");




        }

    }
}
