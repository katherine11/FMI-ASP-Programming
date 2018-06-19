using System;

namespace WebApplication2.Models
{
    public class Catalog
    {
        public string name { get; set; }
        public DateTime startDate { get; set; }
        public DateTime endDate { get; set; }

        public Catalog()
        {
            
        }
        
        public Catalog(string name, DateTime startDate, DateTime endDate)
        {
            this.name = name;
            this.startDate = startDate;
            this.endDate = endDate;
        }

        
    }
}