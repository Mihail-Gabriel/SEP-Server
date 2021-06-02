using System.Collections.Generic;

namespace Sep3.Models
{
    public class Order
    {
        public string name { get; set; }
        public IList<OrderFood> orderItems { get; set; }
        public double price { get; set; }
    }
}