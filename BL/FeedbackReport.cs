using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class FeedbackReport
    {
        public string StudentName { get; set; }
        public string EventTitle { get; set; }
        public int Rating { get; set; }
        public string Comment { get; set; }
        public DateTime SubmittedAt { get; set; }
    }
}
