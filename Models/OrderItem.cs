using System;
using System.Collections.Generic;

namespace ResturantApp.Models
{
    public partial class OrderItem
    {
        public int Id { get; set; }
        public int Quntity { get; set; }
        public int ProductPrice { get; set; }
        public int TotalProductPrice { get; set; }
        public int ProuductId { get; set; }
        public int OrderId { get; set; }

        public virtual Order Order { get; set; } = null!;
        public virtual Product Prouduct { get; set; } = null!;
    }
}
