using DB_Final.BL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Sponsor : Person
    {
        private int _id;
        private string _organization;
        public int Id { get { return _id; } }
        public string Organization { get { return _organization; } set { _organization = value; } }
        //to load from db
        public Sponsor(int id, string name, string org, string email, string phone) : base(name, email, phone)
        {
            _id = id;
            this.Organization = org;
        }
        //to load in db
        public Sponsor(string name, string org, string email, string phone) : base(name, email, phone)
        {
            this.Organization = org;
        }
    }
}
