using System.Collections.Generic;

namespace Sep3.Models
{
    public class Branch
    {
        public int id { get; set; }
        public string theme { get; set; }
        public string city { get; set; }
        public IList<Meal> menu { get; set; }
        
        
    }
}