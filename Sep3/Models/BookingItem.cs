namespace Sep3.Models
{
    public class BookingItem
    {
        public string Name{ get; set; }
        public string Time{ get; set; }
        public string Date{ get; set; }

        public BookingItem(string name, string time, string date)
        {
            this.Name = name;
            this.Time = time;
            this.Date = date;
        }
        
    }
}