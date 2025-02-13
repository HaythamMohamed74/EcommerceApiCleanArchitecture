using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Models
{
    public class GetAllProductQuery : IRequest<List<Product>>
    {

    }
}
