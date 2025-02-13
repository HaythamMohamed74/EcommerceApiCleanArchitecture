using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results
{
    public class GetAllProductListResponse
    {
       
        public int Id { get; set; }
        public string Name { get; set; }

        public string? Description { get; set; }


    }
}
