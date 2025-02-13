using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EccomerceApiCleanArchitecture.Data.Entities
{
    public class Order : BaseEntity
    {
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Required]
        public  string  OrderNumber { get; set; }

        [Required]
        public string UserId { get; set; }

        //public virtual User User { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal SubTotal { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal ShippingCost { get; set; }
        [Required]
        [Column(TypeName = "decimal(18,2)")]
        public decimal Total { get; set; }
        [ForeignKey("OrderAddress")]
        public  int OrderAddressId { get; set; }
        [Required]
        //public OrderStatus OrderStatus { get; set; } = OrderStatus.Pending;

        public DateTime OrderDate { get; set; } = DateTime.Now;

        [Column(TypeName = "decimal(18,2)")]
        public decimal? DiscountAmount { get; set; }

        [StringLength(50)]
        public string? CouponCode { get; set; }

        //public virtual ApplicationUser User { get; set; }
        public virtual OrderAddress OrderAddress { get; set; }
        public virtual ICollection<OrderItem> OrderItems { get; set; } = new HashSet<OrderItem>();

    }
}