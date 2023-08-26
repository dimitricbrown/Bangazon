using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class PaymentTypes
    {
        public int Id { get; set; }
        [Required]
        public string Type { get; set; }
    }
}
