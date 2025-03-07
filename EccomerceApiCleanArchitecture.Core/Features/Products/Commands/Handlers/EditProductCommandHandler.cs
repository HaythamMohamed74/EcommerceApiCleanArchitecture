using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Models;
using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Handlers
{
    public class EditProductCommandHandler : 
        ResponseHandler,
        IRequestHandler<EditProductCommand, Response<int>>
    {
        private readonly IProductService _productService;

        public EditProductCommandHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<Response<int>> Handle(EditProductCommand request, CancellationToken cancellationToken)
        {
            var product = await _productService.GetProductByIdAsync(request.Id);
            if (product == null) {
                return NotFound<int>("Product Not Found");
            }
            // Update product properties
            product.Name = request.Name;
            product.Description = request.Desc;
            product.Price = request.Price;
            product.StockQuantity = request.StockQuantity;

            // Save changes
            await _productService.UpdateProduct(product);

            return  Success(product.Id);



        }
    }
}
