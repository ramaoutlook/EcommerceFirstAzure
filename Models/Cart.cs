using Microsoft.AspNetCore.Identity;

namespace Ecommerce8.Models
{
    public class Cart
    {
        public int id { get; set; }
        public int ProductId { get; set; }
        public Product Product { get; set; }
        public int Qty { get; set; }

        public string UserId { get; set; }

        public IdentityUser user { get; set; }

    }
}
