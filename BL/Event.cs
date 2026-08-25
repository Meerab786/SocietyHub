using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Sockets;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Event
    {
        private int _id;
        private string _status;
        private string _description;
        private int _capacity;
        private string _title;
        private DateTime _eventDateTime;
        private Society _society;
        private Venue _venue;
        private EventCategory _category;
        public int Id { get { return _id; } }
        public string Status { get { return _status; } set { _status = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public int Capacity { get { return _capacity; } set { if (value <= 0) throw new ArgumentException("Invalid Capacity!"); _capacity = value; } }
        public string Title { get { return _title; } set { if (string.IsNullOrEmpty(value)) throw new ArgumentException("Invalid Title!"); _title = value; } }
        public DateTime EventDateTime { get { return _eventDateTime; } set { _eventDateTime = value; } }
        public Society Society { get { return _society; } set { _society = value; } }
        public Venue Venue { get { return _venue; } set { _venue = value; } }
        public EventCategory Category { get { return _category; } set { _category = value; } }
        public Event(int id, string status, string description, int capacity, string title, DateTime date, Society society, Venue venue, EventCategory category)
        {
            _id = id;
            this.Status = status;
            this.Description = description;
            this.Capacity = capacity;
            this.Title = title;
            this.EventDateTime = date;
            this.Society = society;
            this.Venue = venue;
            this.Category = category;
        }
        public Event(string status, string description, int capacity, string title, DateTime date, Society society, Venue venue, EventCategory category)
        {
            this.Status = status;
            this.Description = description;
            this.Capacity = capacity;
            this.Title = title;
            this.EventDateTime = date;
            this.Society = society;
            this.Venue = venue;
            this.Category = category;
        }
    }
}
