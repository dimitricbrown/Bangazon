using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class SellerProducts
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Products Product { get; set; }
        public int UserId { get; set; }
        public Users User { get; set; }
    }
}
