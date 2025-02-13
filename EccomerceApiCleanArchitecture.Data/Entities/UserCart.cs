using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EccomerceApiCleanArchitecture.Data.Entities
{
    public class UserCart : BaseEntity
    {

        [Required]
        //public string UserId { get; set; }
        //public User User { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }
        public Product Product { get; set; }

        public int Quantity { get; set; }
     
    }
}