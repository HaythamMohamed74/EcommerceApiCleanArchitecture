using AutoMapper;
using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Handlers
{
    public class GetProductByIdQueryHandler : 
        ResponseHandler,
        IRequestHandler<GetProductByIdQuery, Response<GetSingleProductResponse>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public GetProductByIdQueryHandler(IProductService productService,IMapper mapper)
        {
           _productService = productService;
            _mapper = mapper;
        }
        public async Task<Response<GetSingleProductResponse>> Handle(GetProductByIdQuery request, CancellationToken cancellationToken)
        {
            var productService = await _productService.GetProductByIdAsync(request.Id);
            if (productService == null) { 
            return NotFound<GetSingleProductResponse>($"Product with {request.Id} Not Found");
            }
            var result = _mapper.Map<GetSingleProductResponse>(productService);
            return  Success(result);

        }
    }
}
