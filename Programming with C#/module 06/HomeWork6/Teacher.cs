using System;

namespace HomeWork6
{
    public class Teacher : Person
    {
        public Teacher(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void GradeTest()
        {
            Console.WriteLine(String.Format("The teacher {0} {1} grade a test", FirstName, LastName));
        }
    }
}