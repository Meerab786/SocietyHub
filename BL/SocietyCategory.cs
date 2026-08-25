using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class SocietyCategory : Category
    {
        private int _id;
        public int Id { get { return _id; } }

        //to load into db
        public SocietyCategory(int id, string name, string description) : base(name, description)
        {
            _id = id;
        }
        //to save in db
        public SocietyCategory(string name, string description) : base(name, description)
        {
        }
    }
}
