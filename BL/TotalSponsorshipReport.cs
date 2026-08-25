using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class TotalSponsorshipReport
    {
        public string EventTitle { get; set; }
        public string SocietyName { get; set; }
        public int TotalSponsors { get; set; }
        public decimal TotalAmount { get; set; }
    }
}
