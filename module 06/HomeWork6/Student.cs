using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork6
{
    public class Student : Person
    {
        private Stack<int> gradesStack = new Stack<int>();

        public Student(string firstName, string lastName) : base(firstName, lastName)
        {
        }

        public void TakeTest()
        {
            gradesStack.Push(100);
            gradesStack.Push(96);
            gradesStack.Push(89);
            gradesStack.Push(77);
            gradesStack.Push(94);
        }

        public override string ToString()
        {
            return String.Format("Student {0} , {1}", FirstName, LastName);
        }
    }
}