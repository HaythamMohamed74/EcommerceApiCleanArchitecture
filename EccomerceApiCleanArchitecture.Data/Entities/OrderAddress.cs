using System.ComponentModel.DataAnnotations;

namespace EccomerceApiCleanArchitecture.Data.Entities
{
    public class OrderAddress : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Street { get; set; }

        [Required]
        [StringLength(50)]
        public string City { get; set; }

        [Required]
        [StringLength(50)]
        public string State { get; set; }

        
        [StringLength(20)]
        public string? ZipCode { get; set; }

        [Required]
        [StringLength(50)]
        public string Country { get; set; }

        [Required]
        public string UserId { get; set; }  // Link to user who owns this address

        [StringLength(20)]
        public string? PhoneNumber { get; set; }

        // Navigation Properties
        //public virtual ApplicationUser User { get; set; }
        public virtual ICollection<Order> ShippingOrders { get; set; } = new HashSet<Order>();
        
    }
}