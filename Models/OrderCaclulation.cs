using System.ComponentModel.DataAnnotations;

namespace ResturantApp.Models
{
    public class OrderCaclulation
    {
        [Key]
        public int Id { get; set; }

        public Product Product { get; set; }
        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
