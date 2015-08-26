using System;

namespace HomeWork6
{
    public class Degree
    {
        public string NameDegree { get; set; }

        public Degree(string nameDegree)
        {
            NameDegree = nameDegree;
        }

        public Course Course { get; set; }

        public override string ToString()
        {
            return String.Format("The {0} of Science degree contains the course {1}", NameDegree, Course.Name);
        }
    }
}