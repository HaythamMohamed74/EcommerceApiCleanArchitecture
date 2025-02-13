using System.ComponentModel.DataAnnotations.Schema;

namespace EccomerceApiCleanArchitecture.Data.Entities
{
    public class ProductImage : BaseEntity
    {
        public string ImageUrl { get; set; }

        public bool IsMainImage { get; set; }= false;
        [ForeignKey("Product")]
        public int ProductId { get; set; }
        public virtual Product Product { get; set; }
    }
}