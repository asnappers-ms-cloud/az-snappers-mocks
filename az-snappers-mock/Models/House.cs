using System;
using System.Collections.Generic;
using System.Text;

namespace az_snappers_mock.Models
{
    public class House
    {
        public string Zipcode { get; set; }
        public string Area { get; set; }
        public DateTime contrustiedIn { get; set; }
        public int AgeInYears { get; set; }
        public int NumberOfBedrooms { get; set; }
        public decimal Cost { get; set; }
        
    }
}
