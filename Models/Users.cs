using System.ComponentModel.DataAnnotations;

namespace Bangazon.Models
{
    public class Users
    {
        public int Id { get; set; }
        [Required]
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Address { get; set; }
        public bool IsSeller { get; set; }
        public List<Orders> Orders { get; set; }
        public List<Products> Products { get; set; }
    }
}
