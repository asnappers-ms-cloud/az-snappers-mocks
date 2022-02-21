using System;
using System.Collections.Generic;
using System.Text;

namespace az_snappers_mock.Models
{
    public class QuoteResponse
    {
        public decimal  HouseCost    { get; set; }
        public bool IsPreapproved { get; set; }
        public string APR { get; set; }

        public string DisplayName { get; set; }


    }
}
