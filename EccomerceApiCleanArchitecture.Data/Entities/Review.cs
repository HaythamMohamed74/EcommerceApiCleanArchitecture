using System.ComponentModel.DataAnnotations.Schema;

namespace EccomerceApiCleanArchitecture.Data.Entities;


    public class Review: BaseEntity
    {

      
        public string Comment { get; set; }
        public int Rate { get; set; }
        public DateTime dateTime { get; set; } = DateTime.Now;

        public int UserId { get; set; }
        //public User user { get; set; }
        [ForeignKey(nameof(Product))]
        public int ProductId { get; set; }

        public virtual Product Product { get; set; }

      public int? OrderItemId { get; set; }
      public virtual OrderItem OrderItem { get; set; }

}
