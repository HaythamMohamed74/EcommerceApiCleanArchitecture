using AutoMapper;
using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using EccomerceApiCleanArchitecture.Service.Implemtations;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Handlers
{
    public class GetProductByNameHandler :  ResponseHandler,
        IRequestHandler<GetProductByNameQuery, Response<List< GetAllProductListResponse>>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public GetProductByNameHandler( IProductService productService,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }
        public async Task<Response<List< GetAllProductListResponse>>> Handle(GetProductByNameQuery request, CancellationToken cancellationToken)
        {
          var productService = await _productService.GetProductsByNameAsync(request.Name);
            var result =  _mapper.Map<List<GetAllProductListResponse>>(productService);
            if (result == null)
            {
                return Failure<List<GetAllProductListResponse>>("Product Not Found");
            }
            return Success(result);
         

        }
    }
}
