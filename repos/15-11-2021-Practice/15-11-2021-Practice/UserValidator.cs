using System;
using System.Collections.Generic;
using System.Text;

namespace _15_11_2021_Practice
{
    class UserValidator
    {
        public bool CheckName(string name)
        {
            if (name.Length > 3) return true;
            

            return false;
        }

        public bool CheckSurname(string surname)
        {
            if (surname.Length > 5) return true;

            return false;
        }
    }

}
