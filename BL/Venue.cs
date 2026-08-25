using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Venue
    {
        private int _id;
        private string _name;
        private string _location;
        private int _capacity;
        private string _facilities;

        public string Status { get; set; }
        public int Id {get 
            {
                return _id;
            } }
        public string Name
        {
            get { 
                return _name; 
            }
            set 
            {
                if (int.TryParse(value, out int temp) || string.IsNullOrWhiteSpace(value))
                    throw new ArgumentException("Invalid Name"); 
                _name = value; 
            }
        }
        public string Location
        {
            get { return _location; }
            set 
            {
                if (int.TryParse(value, out int temp) || string.IsNullOrWhiteSpace(value)) 
                    throw new ArgumentException("Invalid Location"); 
                _location = value; 
            }
        }
        public int Capacity
        {
            get { return _capacity; }
            set
            {
                if (value < 0)
                    throw new ArgumentException("Invalid Capacity");

                _capacity = value;
            }
        }
        public string Facilities { get { return _facilities; } set { _facilities = value; } }
        public Venue(int id, string name, string location, int capacity, string facilities)
        {
            _id = id;
            Name = name;
            Location = location;
            Capacity = capacity;
            Facilities = facilities;
        }
        public Venue(string name, string location, int capacity, string facilities)
        {
            Name = name;
            Location = location;
            Capacity = capacity;
            Facilities = facilities;
        }
    }
}
