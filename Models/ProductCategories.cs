using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class ProductCategories
    {
        public int Id { get; set; }
        [Required]
        public int ProductId { get; set; }
        public Products Product { get; set; }
        public int CategoryId { get; set; }
        public Categories Category { get; set; }

    }
}
