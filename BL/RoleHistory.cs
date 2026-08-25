using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class RoleHistory
    {
        private int _id;
        private DateTime _startDate;
        private DateTime? _endDate;
        private string _roleTitle;
        private Membership _membership;

        public int Id { get { return _id; } }
        public DateTime StartDate
        {
            get { return _startDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Start date cannot be in the future!");
                _startDate = value;
            }
        }
        public DateTime? EndDate
        {
            get { return _endDate; }
            set
            {
                if (value != null && value < _startDate)
                    throw new ArgumentException("End date cannot be before start date!");
                _endDate = value;
            }
        }
        public string RoleTitle { get { return _roleTitle; } set { _roleTitle = value; } }
        public Membership Membership { get { return _membership; } set { _membership = value; } }

        // to load from db
        public RoleHistory(int id, DateTime startDate, DateTime? endDate, string roleTitle, Membership membership)
        {
            _id = id;
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.RoleTitle = roleTitle;
            this.Membership = membership;
        }
        // to save in db
        public RoleHistory(DateTime startDate, DateTime? endDate, string roleTitle, Membership membership)
        {
            this.StartDate = startDate;
            this.EndDate = endDate;
            this.RoleTitle = roleTitle;
            this.Membership = membership;
        }
    }
}
