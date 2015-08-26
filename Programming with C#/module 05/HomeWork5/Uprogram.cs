using System;

namespace HomeWork5
{
    public class UProgram
    {
        public string Name { get; set; }

        public UProgram(string name)
        {
            Name = name;
        }

        public Degree Degree { get; set; }

        public override string ToString()
        {
            return String.Format("The {0} program contains the {1} of Science degree", Name, Degree.NameDegree);
        }
    }
}