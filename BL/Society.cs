using DB_Final.DL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Society
    {
        private int _id;
        private string _name;
        private string _status;
        private DateTime _foundedDate;
        private string _description;
        private SocietyCategory _category;
        private string _logoPath;

        public int MemberCount { get; set; }

        public int Id { get { return _id; } }
        public string Name { get { return _name; } set { if (int.TryParse(value, out int temp) || string.IsNullOrWhiteSpace(value)) throw new ArgumentException("Invalid Name!"); _name = value; } }
        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }
        public DateTime FoundedDate
        {
            get { return _foundedDate; }
            set
            {
                _foundedDate
                     = value.Date;
            }
        }
        public string Description { get { return _description; } set { _description = value; } }
        public SocietyCategory Category
        {
            get { return _category; }
            set { _category = value; }
        }

        public string LogoPath
        {
            get { return _logoPath; }
            set { _logoPath = value; }
        }

        public Society(int id, string name, string description, DateTime date, SocietyCategory category, string status)
        {
            _id = id;
            this.Name = name;
            this.Status = status;
            this.Description = description;
            this.FoundedDate = date;
            this.Category = category;
        }
        public Society(string name, string description, DateTime date, SocietyCategory category, string status)
        {
            this.Name = name;
            this.Status = status;
            this.Description = description;
            this.FoundedDate = date;
            this.Category = category;
        }

        public Society(int id, string name, string description,DateTime date, SocietyCategory category, string status, string logoPath)
        {
            _id = id;
            Name = name;
            Description = description;
            FoundedDate = date;
            Category = category;
            Status = status;
            LogoPath = logoPath;
        }

        public Society( string name,string description,DateTime date,SocietyCategory category,string status,string logoPath)
        {
            Name = name;
            Description = description;
            FoundedDate = date;
            Category = category;
            Status = status;
            LogoPath = logoPath;
        }
    }
}
