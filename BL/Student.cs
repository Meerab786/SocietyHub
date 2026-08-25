using Google.Protobuf.Compiler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
    public class Student : Person
    {
        private int _id;
        private int _batchYear;
        private string _department;
        private string _status;
        private string _regNo;

        public int Id
        {
            get { return _id; }
        }

        public string Department
        {
            get { return _department; }
            set { _department = value; }
        }

        public int BatchYear
        {
            get { return _batchYear; }
            set
            {
                if (value < 2000 || value > DateTime.Now.Year)
                    throw new ArgumentException("Invalid Batch Year");
                _batchYear = value;
            }
        }

        public string Status
        {
            get { return _status; }
            set { _status = value; }
        }

        public string RegNo
        {
            get { return _regNo; }
            set { _regNo = value; }
        }

        // =========================
        // Load from Database
        // =========================
        public Student(int id, string name, int batchYear, string department, string status, string email, string regNo, string phone)
            : base(name, email, phone)
        {
            _id = id;
            _batchYear = batchYear;
            _department = department;
            _status = status;
            _regNo = regNo;
        }

        // =========================
        // Insert into Database
        // =========================
        public Student(string name, int batchYear, string department, string status, string email, string regNo, string phone)
            : base(name, email, phone)
        {
            _batchYear = batchYear;
            _department = department;
            _status = status;
            _regNo = regNo;
        }
    }
}
