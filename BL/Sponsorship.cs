using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Sponsorship
    {
        private int _id;
        private decimal _amount;
        private DateTime _sponsorshipDate;
        private Sponsor _sponsor;
        private Event _event;
        public int Id { get { return _id; } }
        //public string SponsorName { get; set; }
        //public string SponsorOrganization { get; set; }
        //public string EventTitle { get; set; }
        public decimal Amount
        {
            get { return _amount; }
            set
            {
                if (value <= 0)
                    throw new ArgumentException("Amount must be greater than 0!");
                _amount = value;
            }
        }
        public DateTime SponsorshipDate
        {
            get { return _sponsorshipDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Sponsorship date cannot be in the future!");
                _sponsorshipDate = value;
            }
        }
        public Sponsor Sponsor { get { return _sponsor; } set { _sponsor = value; } }
        public Event Event { get { return _event; } set { _event = value; } }

        // to load from db
        public Sponsorship(int id, decimal amount, DateTime sponsorshipDate, Sponsor sponsor, Event ev)
        {
            _id = id;
            this.Amount = amount;
            this.SponsorshipDate = sponsorshipDate;
            this.Sponsor = sponsor;
            this.Event = ev;
        }
        // to save in db
        public Sponsorship(decimal amount, DateTime sponsorshipDate, Sponsor sponsor, Event ev)
        {
            this.Amount = amount;
            this.SponsorshipDate = sponsorshipDate;
            this.Sponsor = sponsor;
            this.Event = ev;
        }
    }
}
