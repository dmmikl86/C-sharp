﻿using System;
using System.Collections.Generic;

namespace HomeWork6
{
    public class Course
    {
        public string Name { get; set; }
        private List<Student> _students = new List<Student>();
        private List<Teacher> _teachers = new List<Teacher>();
        private String allStudents = "\n\t";


        public Course(string name)
        {
            Name = name;
        }

        public void AddStudent(Student student)
        {
            _students.Add(student);
        }

        public void AddStudents(List<Student> students)
        {
            foreach (Student student in students)
            {
                _students.Add(student);
            }
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
            _students.ForEach(Print);
            return String.Format("The {0} course contain {1} student<s>: {2}", Name, _students.Count, allStudents);
        }

        private void Print(Student student)
        {
            allStudents += (student + "; ");
        }

        public void ListStudent()
        {
            foreach (Student student in _students)
            {
                Console.WriteLine(student);
            }
        }
    }
}