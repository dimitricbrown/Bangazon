using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class OrderProducts
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Orders? Order { get; set; }
        public int ProductId { get; set; }
        public Products? Product { get; set; }
    }
}
