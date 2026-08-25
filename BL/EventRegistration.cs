using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class EventRegistration
    {
        private int _id;
        private DateTime _registrationDate;
        private string _status;
        private DateTime? _cancellationDate;
        private string _cancellationReason;
        private Student _student;
        private Event _event;
        private EventRegistration selectedRegistration;

        public int Id { get { return _id; } }
        public DateTime RegistrationDate
        {
            get { return _registrationDate; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Registration date cannot be in the future!");
                _registrationDate = value;
            }
        }
        public string Status { get { return _status; } set { _status = value; } }

        public DateTime? CancellationDate
        {
            get { return _cancellationDate; }
            set
            {
                if (value != null && value < _registrationDate)
                    throw new ArgumentException("Cancellation date cannot be before registration date!");
                _cancellationDate = value;
            }
        }
        public string CancellationReason { get { return _cancellationReason; } set { _cancellationReason = value; } }
        public Student Student { get { return _student; } set { _student = value; } }
        public Event Event { get { return _event; } set { _event = value; } }

        // to load from db
        public EventRegistration(int id, DateTime registrationDate, string status, DateTime? cancellationDate, string cancellationReason, Student student, Event ev)
        {
            _id = id;
            this.RegistrationDate = registrationDate;
            this.Status = status;
            this.CancellationDate = cancellationDate;
            this.CancellationReason = cancellationReason;
            this.Student = student;
            this.Event = ev;
        }
        // to save in db
        public EventRegistration(DateTime registrationDate, string status, Student student, Event ev)
        {
            this.RegistrationDate = registrationDate;
            this.Status = status;
            this.CancellationDate = null;
            this.CancellationReason = null;
            this.Student = student;
            this.Event = ev;
        }
    }
}
