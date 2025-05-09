using System.ComponentModel.DataAnnotations;

namespace OP.Models
{
    public class Orders
    {
        [Key]
        public int OrderId { get; set; }
        public decimal TotalAmount { get; set; }

        public DateOnly OrderDate { get; set; }

        public string OrderStatus { get; set; }

    }
}
