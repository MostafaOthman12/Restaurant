using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace ResturantApp.Models
{
    public partial class Order
    {
        public Order()
        {
            OrderItems = new HashSet<OrderItem>();
        }

        public int Id { get; set; }
        public DateTime Date { get; set; }
        public int FinalPrice { get; set; }
        [ForeignKey("User")]
        public string UserId { get; set; }
        public virtual AspNetUser User { get; set; }

        public virtual ICollection<OrderItem> OrderItems { get; set; }
    }
}
