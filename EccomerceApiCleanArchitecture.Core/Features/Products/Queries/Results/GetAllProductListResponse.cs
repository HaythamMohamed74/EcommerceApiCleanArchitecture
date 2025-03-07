using EccomerceApiCleanArchitecture.Common.Enums;
using EccomerceApiCleanArchitecture.Data.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EccomerceApiCleanArchitecture.Core.Dtos._Products;
using EccomerceApiCleanArchitecture.Core.Dtos.Categories;

namespace EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results
{
    public class GetAllProductListResponse
    {

        public  int  Id { get; set; }
        public string Name { get; set; }
        
        public string Description { get; set; }
   
        public decimal Price { get; set; }
       
        public int StockQuantity { get; set; }
       
        public bool IsActive { get; set; } = true;

        public CategoryDto Category { get; set; }

        public List<ProductImageDto> imagesUrl { get; set; }=new HashSet<ProductImageDto>().ToList();
        public List<ProductReviewDto> Reviews { get; set; } = new HashSet<ProductReviewDto>().ToList();

        public ProductStatus Status { get; set; } = ProductStatus.Draft;

        public double AverageRating => Reviews?.Any() == true
           ? Reviews.Average(r => r.Rating)
           : 0;
        public int TotalReviews => Reviews?.Count ?? 0;



    }
}
