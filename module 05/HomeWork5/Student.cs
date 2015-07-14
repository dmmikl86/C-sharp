namespace HomeWork5
{
    public class Student
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Student(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}