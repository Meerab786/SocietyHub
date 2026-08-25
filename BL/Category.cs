using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public abstract class Category
    {
        private string _name;
        private string _description;
        public string Name { get { return _name; } set { if (int.TryParse(value, out int temp) || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid Name"); _name = value; } }
        public string Description { get { return _description; } set { _description = value; } }
        public Category(string name, string description)
        {
            Name = name;
            Description = description;
        }
    }
}
