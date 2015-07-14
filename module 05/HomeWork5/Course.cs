using System;
using System.Collections.Generic;

namespace HomeWork5
{
    public class Course
    {
        public string Name { get; set; }
        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();


        public Course(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudents(Student[] students)
        {
            _students.AddRange(students);
        }

        public void AddTeacher(Teacher teacher)
        {
            _teachers.Add(teacher);
        }

        public void AddTeachers(Teacher[] teachers)
        {
            _teachers.AddRange(teachers);
        }

        public override string ToString()
        {
            return String.Format("The {0} course contain {1} student<s>", Name, _students.Count);
        }
    }
}