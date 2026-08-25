using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DB_Final.BL
{
        public abstract class Person
        {
            private string _name;
            private string _email;
            private string _phone;

            public string Email
            {
                get { return _email; }
                set
                {
                    if (value.Contains("@") && value.Contains('.'))
                        _email = value;
                    else
                        throw new ArgumentException("Invalid Email!");
                }
            }

            public string Name
            {
                get { return _name; }
                set
                {
                    if (int.TryParse(value, out _) || string.IsNullOrWhiteSpace(value))
                        throw new ArgumentException("Name can't be digits or empty!");
                    _name = value;
                }
            }

            public string Phone
            {
                get { return _phone; }
                set
                {
                    if (string.IsNullOrWhiteSpace(value) || value.Length > 15 || !value.All(char.IsDigit))
                        throw new ArgumentException("Invalid Phone");
                    _phone = value;
                }
            }

            public Person(string name, string email, string phone)
            {
                Name = name;
                Email = email;
                Phone = phone;
            }
        }
    }