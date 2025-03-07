using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using MediatR;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models
{
    public class GetAllProductQuery : IRequest<Response<List<GetAllProductListResponse>>>
    {
        // This is just a query request and does not need properties.
    }
}
