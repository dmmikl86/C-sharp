using System;

namespace HomeWork6
{
    public class Student : Person
    {
        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void TakeTest()
        {
            Console.WriteLine(String.Format("The student {0} {1} take a test", FirstName, LastName));
        }
    }
}