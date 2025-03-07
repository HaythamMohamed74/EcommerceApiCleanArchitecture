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
    public class AddNewProductHandler :  ResponseHandler,
        IRequestHandler<AddNewProductCommand,Response< int>>
    {
        private readonly IProductService _productService;

        public AddNewProductHandler(IProductService productService)
        {
            _productService = productService;
        }
        public async Task<Response<int>>Handle(AddNewProductCommand request, CancellationToken cancellationToken)
        {
            //return _productService.AddNewProduct(request.Id, request.Name, request.Price);
            var product = new Product
            {
                //Id = request.Id,
                Name = request.Name,
                Price = request.Price,
                StockQuantity = request.StockQuantity,
                Description = request.Desc,
                CategoryId = 10,



            };
         var newProduct= await(_productService.AddNewProduct(product));
            return Created(newProduct.Id);
        }
    }
}
