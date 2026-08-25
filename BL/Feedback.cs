using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Feedback
    {
        private int _id;
        private int _rating;
        private string _comment;
        private DateTime _submittedAt;
        private Student _student;
        private Event _event;

        public int Id { get { return _id; } }
        public int Rating
        {
            get { return _rating; }
            set
            {
                if (value < 1 || value > 5)
                    throw new ArgumentException("Rating must be between 1 and 5!");
                _rating = value;
            }
        }
        public string Comment { get { return _comment; } set { _comment = value; } }
        public DateTime SubmittedAt
        {
            get { return _submittedAt; }
            set
            {
                if (value > DateTime.Now)
                    throw new ArgumentException("Submitted date cannot be in the future!");
                _submittedAt = value;
            }
        }
        public Student Student { get { return _student; } set { _student = value; } }
        public Event Event { get { return _event; } set { _event = value; } }

        // to load from db
        public Feedback(int id, int rating, string comment, DateTime submittedAt, Student student, Event ev)
        {
            _id = id;
            this.Rating = rating;
            this.Comment = comment;
            this.SubmittedAt = submittedAt;
            this.Student = student;
            this.Event = ev;
        }
        // to save in db
        public Feedback(int rating, string comment, DateTime submittedAt, Student student, Event ev)
        {
            this.Rating = rating;
            this.Comment = comment;
            this.SubmittedAt = submittedAt;
            this.Student = student;
            this.Event = ev;
        }
    }
}
