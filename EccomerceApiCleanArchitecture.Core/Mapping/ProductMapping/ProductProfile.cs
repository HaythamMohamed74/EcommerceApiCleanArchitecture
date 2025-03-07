using AutoMapper;
using EccomerceApiCleanArchitecture.Core.Dtos._Products;
using EccomerceApiCleanArchitecture.Core.Dtos.Categories;
using EccomerceApiCleanArchitecture.Core.Features.Products.Queries.Results;
using EccomerceApiCleanArchitecture.Data.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EccomerceApiCleanArchitecture.Core.Mapping.ProductMapping
{
    public class ProductProfile: Profile
    {

        public ProductProfile()
        {
            CreateMap<Product,GetAllProductListResponse>().ReverseMap()
                .ForMember(d=>d.ProductImages,s=>s.MapFrom(s=>s.imagesUrl))
                .ForMember(d => d.Reviews, s => s.MapFrom(s => s.TotalReviews))
                .ForMember(d => d.Category, s => s.MapFrom(s => s.Category)
                );
            CreateMap<Product, GetSingleProductResponse>().ReverseMap()
              .ForMember(d => d.ProductImages, s => s.MapFrom(s => s.imagesUrl))
              .ForMember(d => d.Reviews, s => s.MapFrom(s => s.TotalReviews))
              .ForMember(d => d.Category, s => s.MapFrom(s => s.Category)
              );


            CreateMap<Category, CategoryDto>();

            CreateMap<ProductImage, ProductImageDto>();

            CreateMap<Review, ProductReviewDto>();
        }
    }
}
