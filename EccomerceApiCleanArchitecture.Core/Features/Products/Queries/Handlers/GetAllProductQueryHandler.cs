
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Data.Entities;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using MediatR;

namespace eccomerceapicleanarchitecture.core.features.products.queries.handlers
{
    public class Getallproductqueryhandler: IRequestHandler<GetAllProductQuery, List<Product>>
    {
        private readonly IProductService _productService;

        public Getallproductqueryhandler(  IProductService productService )
        {
            _productService = productService;
        }

        public async Task<List<Product>> Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
           return await   _productService.GetAllProductsAsync();
        }
      
    }
}
