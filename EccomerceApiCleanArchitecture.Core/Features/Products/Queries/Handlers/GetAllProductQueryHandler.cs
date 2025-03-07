
using AutoMapper;
using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Service.Abstracts;
using MediatR;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Handlers;
    public class GetAllProductQueryHandler :ResponseHandler,
        IRequestHandler<GetAllProductQuery,Response<List<GetAllProductListResponse>>>
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;

        public GetAllProductQueryHandler(  IProductService productService ,IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public async Task<Response<List<GetAllProductListResponse>>>Handle(GetAllProductQuery request, CancellationToken cancellationToken)
        {
            
             var productService=await _productService.GetAllProductsAsync();
            var result = _mapper.Map<List<GetAllProductListResponse>>(productService);
            return Success(result);


        }
    }



  

