using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models
{
    public class GetProductByIdQuery : IRequest<Response<GetSingleProductResponse>>
    {
        public int Id { get; set; }
        public GetProductByIdQuery(int id )
        {
            Id = id;
        }
    }
}
