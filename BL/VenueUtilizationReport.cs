using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class VenueUtilizationReport
    {
        public string VenueName { get; set; }
        public string Location { get; set; }
        public int VenueCapacity { get; set; }
        public string EventTitle { get; set; }
        public DateTime EventDatetime { get; set; }
        public string Status { get; set; }
    }
}
