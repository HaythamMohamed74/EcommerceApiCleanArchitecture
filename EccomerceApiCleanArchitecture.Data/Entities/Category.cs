using System.ComponentModel.DataAnnotations;

namespace EccomerceApiCleanArchitecture.Data.Entities
{
    public class Category : BaseEntity
    {
        [Required]
        [StringLength(100)]
        public string Name { get; set; }

        [StringLength(500)]
        public string? Description { get; set; }
        public string? ImageUrl { get; set; }
        [Required]
        public bool IsActive { get; set; } = true;
        public virtual ICollection<Product> Products { get; set; } = new HashSet<Product>();

    }
}