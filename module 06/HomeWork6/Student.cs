using System;
using System.Collections;

namespace HomeWork6
{
    public class Student : Person
    {
        private Stack gradesStack = new Stack();

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void TakeTest()
        {
            gradesStack.Push("Computer Science");
            gradesStack.Push("Data Science");
            gradesStack.Push("Softwere Developer");
        }

        public override string ToString()
        {
            return String.Format("Student {0} , {1}", FirstName, LastName);
        }
    }
}