namespace HomeWork5
{
    public class Teacher
    {
        public string Name { get; set; }
        public string LastName { get; set; }

        public Teacher(string name, string lastName)
        {
            Name = name;
            LastName = lastName;
        }
    }
}