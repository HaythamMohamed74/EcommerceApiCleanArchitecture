using EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Models;
using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Validations
{
    public class AddNewProductValidator:AbstractValidator<AddNewProductCommand>
    {

        public AddNewProductValidator()
        {
            RuleFor(x => x.Name).NotEmpty().WithMessage("Name is required");
            RuleFor(x => x.Price).GreaterThan(0).WithMessage("Price is required");  
            RuleFor(x => x.StockQuantity).GreaterThanOrEqualTo(0).WithMessage("Stock is required");  


        }
    }
}
