using System;
using System.Collections;
using System.Collections.Generic;

namespace HomeWork6
{
    internal class Program
    {
        private const int SIZE = 3;

        private static void Main(string[] args)
        {
            ArrayList students = new ArrayList();
            students.Add(new Student("Mich", "Dm"));
            students.Add(new Student("Scott", "Liv"));
            students.Add(new Student("Max", "Bill"));

            ArrayList teachers = new ArrayList();
            teachers.Add(new Teacher("Oleg", "Basilica"));

            Degree degree = new Degree("Bachelor");
            UProgram uProgram = new UProgram("Information Technology");

            Course course = new Course("Programming with C#");
            course.AddStudents(students);
            course.AddTeacher((Teacher)teachers[0]);
            degree.Course = course;
            uProgram.Degree = degree;

            course.ListStudent();


            Console.WriteLine(uProgram.ToString());
            Console.WriteLine(degree.ToString());
            Console.WriteLine(course.ToString());
        }
    }
}