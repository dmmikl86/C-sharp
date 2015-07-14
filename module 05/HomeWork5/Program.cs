using System;

namespace HomeWork5
{
    internal class Program
    {
        private const int SIZE = 3;

        private static void Main(string[] args)
        {
            Student[] students = new Student[SIZE];
            students[0] = new Student("Mich", "Dm");
            students[1] = new Student("Scott", "Liv");
            students[2] = new Student("Max", "Bill");

            Teacher[] teachers = new Teacher[SIZE];
            teachers[0] = new Teacher("Oleg", "Basilica");

            Degree degree = new Degree("Bachelor");
            UProgram uProgram = new UProgram("Information Technology");

            Course course = new Course("Programming with C#");
            course.AddStudents(students);
            course.AddTeacher(teachers[0]);
            degree.Course = course;
            uProgram.Degree = degree;

            Console.WriteLine(uProgram.ToString());
            Console.WriteLine(degree.ToString());
            Console.WriteLine(course.ToString());
        }
    }
}