using System;

namespace Homework3
{
    internal class Program
    {
        private static Student _student;
        private static Teacher _teacher;

        private static void Main(string[] args)
        {
            _student = new Student();
            _teacher = new Teacher();
            GetStudentInformation();
            GetTeacherInformation();

            Console.WriteLine("press any key to see info");
            Console.ReadKey();
            Console.WriteLine();
            PrintInfo();
            Console.ReadKey();
        }

        private static void PrintInfo()
        {
            Console.WriteLine(_student.ToString());
            Console.WriteLine(_teacher.ToString());
        }

        private static void GetStudentInformation()
        {
            Console.WriteLine("Enter the student's first name: ");
            _student.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the student's last name: ");
            _student.LastName = Console.ReadLine();
            Console.WriteLine("Enter the student birthday separated by dot (.): ");
            ValidateBirthday(Console.ReadLine());
        }

        private static void GetTeacherInformation()
        {
            Console.WriteLine("Enter the teacher's first name: ");
            _teacher.FirstName = Console.ReadLine();
            Console.WriteLine("Enter the teacher's course: ");
            _teacher.Course = Console.ReadLine();
            Console.WriteLine("Enter the teacher specialization: ");
            _teacher.Specialization = Console.ReadLine();
        }

        private static void ValidateBirthday(string birthday)
        {
            DateTime validBirthday;
            if (DateTime.TryParse(birthday, out validBirthday))
            {
                string.Format("{0:d/MM/yyyy}", validBirthday);
                _student.Birthday = validBirthday;
            }
            else
            {
                Console.WriteLine("Invalid Date");
            }
        }

        #region helperClasses

        private class Student
        {
            private string firstName = "";
            private string lastName = "";

            public Student()
            {
                Birthday = new DateTime();
            }

            public string FirstName { get; set; }

            public string LastName { get; set; }

            public DateTime Birthday { private get; set; }

            public override string ToString()
            {
                return "STUDENT INFO: " + firstName + " " + lastName + " " + Birthday.ToShortDateString();
            }
        }

        private class Teacher
        {
            private string course = "";
            private string firstName = "";
            private string specialization = "";

            public string Course { get; set; }

            public string Specialization { get; set; }

            public string FirstName { get; set; }

            public override string ToString()
            {
                return "TEACHER INFO: " + firstName + " " + course + " " + specialization;
            }
        }

        #endregion
    }
}