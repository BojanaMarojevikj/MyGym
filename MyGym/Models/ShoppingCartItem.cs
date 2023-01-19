using System.ComponentModel.DataAnnotations;

namespace MyGym.Models
{
    public class ShoppingCartItem
    {
        [Key]
        public int Id { get; set; }

        public Training Training { get; set; }

        public int Amount { get; set; }

        public string ShoppingCartId { get; set; }
    }
}
