using EccomerceApiCleanArchitecture.Core.Bases;
using EccomerceApiCleanArchitecture.Data.Entities;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Commands.Models
{
    public class AddNewProductCommand:IRequest<Response<int>>
    {
        
        public  string Name { get; set; }
        public string Desc { get; set; }
        public decimal Price { get; set; }
        public int StockQuantity { get;  set; }

        
    }
}
