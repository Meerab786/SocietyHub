using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Announcement
    {
        private int _id;
        private string _title;
        private string _message;
        private DateTime _postedAt;
        private Society _society;
        public int Id { get { return _id; } }
        public string Title
        {
            get { return _title; }
            set { if (string.IsNullOrEmpty(value) || int.TryParse(value, out int temp)) throw new ArgumentException("Invalid Title!"); _title = value; }
        }
        public string Message { get { return _message; } set { _message = value; } }
        public DateTime PostedAt { get { return _postedAt; } set { if (value > DateTime.Now) throw new ArgumentException("Invalid Date"); _postedAt = value; } }
        public Society Society { get { return _society; } set { _society = value; } }
        public Announcement(int id, string title, string message, DateTime postedAt, Society society)
        {
            _id = id;
            this.Title = title;
            this.PostedAt = postedAt;
            this.Message = message;
            this.Society = society;
        }
        public Announcement(string title, string message, DateTime postedAt, Society society)
        {
            this.Title = title;
            this.PostedAt = postedAt;
            this.Message = message;
            this.Society = society;
        }
    }
}
