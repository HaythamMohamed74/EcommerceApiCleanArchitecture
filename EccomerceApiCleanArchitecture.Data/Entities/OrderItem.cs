using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EccomerceApiCleanArchitecture.Data.Entities
{
    public class OrderItem: BaseEntity
    {
        [Required]
        [ForeignKey(nameof(Order))]
        public int OrderId { get; set; } 
        [Required]
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        [Required]
        [Column(TypeName = "decimal(18,2)")]
        [Range(0, double.MaxValue, ErrorMessage = "UnitPrice cannot be negative.")]
        public decimal UnitPrice { get; set; }

        [Required]
        [Range(1, int.MaxValue, ErrorMessage = "Quantity must be at least 1.")]
        public int Quantity { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountAmount { get; set; }

        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }



    }
}