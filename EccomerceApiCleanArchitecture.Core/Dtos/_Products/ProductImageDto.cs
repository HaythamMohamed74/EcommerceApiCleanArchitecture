using EccomerceApiCleanArchitecture.Core.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Dtos._Products
{
    public class ProductImageDto : BaseDto
    {
        public string ImageUrl { get; set; }
        public int ProductId { get; set; }



    }
}
