using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class EventCategory : Category
    {
        private int _id;
        public int Id { get { return _id; } }

        //to load into db
        public EventCategory(int id, string name, string description) : base(name, description)
        {
            _id = id;
        }
        //to save in db
        public EventCategory(string name, string description) : base(name, description)
        {
        }
    }
}
