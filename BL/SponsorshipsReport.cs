using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class SponsorshipsReport
    {
        public string SponsorName { get; set; }
        public string Organization { get; set; }
        public string EventTitle { get; set; }
        public decimal Amount { get; set; }
        public DateTime SponsorshipDate { get; set; }
    }
}
