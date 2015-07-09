using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework4
{
    internal class Assignment
    {
        private static void Main(string[] args)
        {
            Student[] students = new Student[5];
            for (int i = 0; i < students.Length; i++)
            {
                students[i] = new Student();
            }
            students[0].FirstName = "Michael";
            students[0].LastName = "Dm";
            students[0].Birthday = new DateTime(1986, 09, 27);

            students[1].FirstName = "Smith";
            students[1].LastName = "Poll";
            students[1].Birthday = new DateTime(1983, 01, 11);

            Console.WriteLine(students[0]);
            Console.WriteLine(students[1]);
            Console.ReadKey();
        }

        public struct Student
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }

            public override string ToString()
            {
                return "FirstName: " + FirstName + " \tLastName: " + LastName + " \tBirthday: " +
                       Birthday.ToShortDateString();
            }
        }

        public struct Teacher
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }
            public DateTime Birthday { get; set; }

            public override string ToString()
            {
                return "FirstName: " + FirstName + " \tLastName: " + LastName + " \tBirthday: " +
                       Birthday.ToShortDateString();
            }
        }

        public struct UProgram
        {
            public string ProgramName { get; set; }
            public string DepartmentName { get; set; }
            public string Degrees { get; set; }

            public override string ToString()
            {
                return "ProgramName: " + ProgramName + " \tDepartmentName: " + DepartmentName + " \tDegrees: " + Degrees;
            }
        }

        public struct Course
        {
            private string CourseName { get; set; }
            private int CourseCredits { get; set; }
            private int CourseDuration { get; set; }

            public override string ToString()
            {
                return "CourseName: " + CourseName + " \tCourseCredits: " + CourseCredits + " \tCourseDuration: " +
                       CourseDuration;
            }
        }
    }
}