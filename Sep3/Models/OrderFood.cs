namespace Sep3.Models
{
    public class OrderFood
    {
        public string foodName { get; set; }
        public double foodPrice { get; set; }
        public Orders orders { get; set; }
    }
}