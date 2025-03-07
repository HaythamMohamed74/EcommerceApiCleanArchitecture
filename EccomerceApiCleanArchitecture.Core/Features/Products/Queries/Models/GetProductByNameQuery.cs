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
    public class GetProductByNameQuery:IRequest<Response<List<GetAllProductListResponse>>>
    {
        public string Name { get; set; }

        public GetProductByNameQuery(string name )
        {
            Name = name;
        }
    }
}
