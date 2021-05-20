using System.Collections.Generic;

namespace Sep3.Models
{
    public class Menu
    {
        public string menuName { get; set; }
        public IList<Meal> items;
    }
}