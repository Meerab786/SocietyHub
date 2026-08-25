using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class AllEventsReport
    {
        public string EventTitle { get; set; }
        public string SocietyName { get; set; }
        public string VenueName { get; set; }
        public string Category { get; set; }
        public DateTime EvantDateTime { get; set; }
        public int Capacity { get; set; }
        public string Status { get; set; }
    }
}
