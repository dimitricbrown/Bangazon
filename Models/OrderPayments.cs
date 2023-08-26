using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class OrderPayments
    {
        public int Id { get; set; }
        [Required]
        public int OrderId { get; set; }
        public Orders Order { get; set; }
        public int PaymentTypeId { get; set; }
        public PaymentTypes PaymentType { get; set; }
        public decimal PaymentAmount { get; set; }
        public List<PaymentTypes> PaymentTypes { get; set; }
    }
}
