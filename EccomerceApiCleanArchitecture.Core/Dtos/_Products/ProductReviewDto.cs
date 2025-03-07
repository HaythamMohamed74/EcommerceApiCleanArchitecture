﻿using EccomerceApiCleanArchitecture.Core.Dtos.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Dtos._Products
{
    public class ProductReviewDto : BaseDto
    {
        //public string ReviewerName { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public int ProductId { get; set; }


    }
}
