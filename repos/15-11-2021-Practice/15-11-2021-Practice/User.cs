using System;
using System.Collections.Generic;
using System.Text;

namespace _15_11_2021_Practice
{
    class User
    {

        public User(string name , string surname)
        {
            this.Name = name;
            this.Surname = surname;
        }

        private string _name;
        private string _surname;

        public string Name {
            get => _name;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 3) _name = value;
            }
        }
        public string Surname {
            get => _surname;
            set
            {
                if (string.IsNullOrWhiteSpace(value) || value.Length > 5) _surname = value;
            }
        }
    }
}
