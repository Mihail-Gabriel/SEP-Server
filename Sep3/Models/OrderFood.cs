namespace Sep3.Models
{
    public class OrderFood
    {
        public string Name { get; set; }
        public double Price { get; set; }
        public Order Order { get; set; }
    }
}