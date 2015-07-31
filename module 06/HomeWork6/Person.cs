using System;

namespace HomeWork6
{
    public class Person
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }

        public Person(String firstName, String lastName)
        {
            FirstName = firstName;
            LastName = lastName;
        }

        public override string ToString()
        {
            return String.Format("{0} {1}", FirstName, LastName);
        }
    }
}