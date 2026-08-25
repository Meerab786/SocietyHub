using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Membership
    {
        private int _id;
        private string _status;
        private DateTime _joinDate;
        private DateTime? _leaveDate;
        private Student _student;
        private Society _society;

        public int Id { get { return _id; } }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime JoinDate
        {
            get { return _joinDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Join date cannot be in the future!");
                _joinDate = value;
            }
        }
        public DateTime? LeaveDate
        {
            get { return _leaveDate; }
            set
            {
                if (value != null && value < _joinDate)
                    throw new ArgumentException("Leave date cannot be before join date!");
                _leaveDate = value;
            }
        }
        public Student Student { get { return _student; } set { _student = value; } }
        public Society Society { get { return _society; } set { _society = value; } }

        // to load from db
        public Membership(int id, string status, DateTime joinDate, DateTime? leaveDate, Student student, Society society)
        {
            _id = id;
            this.Status = status;
            this.JoinDate = joinDate;
            this.LeaveDate = leaveDate;
            this.Student = student;
            this.Society = society;
        }
        // to save in db
        public Membership(string status, DateTime joinDate, DateTime? leaveDate, Student student, Society society)
        {
            this.Status = status;
            this.JoinDate = joinDate;
            this.LeaveDate = leaveDate;
            this.Student = student;
            this.Society = society;
        }
    }
}
