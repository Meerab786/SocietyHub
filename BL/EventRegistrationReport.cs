using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class EventRegistrationReport
    {
        public string StudentName { get; set; }
        public string RegNo { get; set; }
        public string EventTitle { get; set; }
        public DateTime RegistrationDate { get; set; }
        public string Status { get; set; }
        public string CancellationReason { get; set; }
    }
}
