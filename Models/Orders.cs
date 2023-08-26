using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class Orders
    {
        public int Id { get; set; }
        [Required]
        public int UserId { get; set; }
        public Users User { get; set; }
        public int OrderStatusTypeId { get; set; }
        public OrderStatusTypes OrderStatusType { get; set; }
        public bool NeedsShipping { get; set; }
        public bool SplitPayment { get; set; }
        public List<Products> Products { get; set; }
        public List<OrderPayments> OrderPayments { get; set; }
    }
}
