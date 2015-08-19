using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mod_9_Homework
{
    public class Student
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string City { get; set; }

        public Student (String firstName, String lastName, String city)
        {
            FirstName = firstName;
            LastName = lastName;
            City = city;
        }
    }
}
