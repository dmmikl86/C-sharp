using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoApp1
{
    class Helper
    {
        private void printLn(Object o)
        {
            Console.WriteLine(o);
        }

        /// linq
        public void do_1()
        {
           List<Person> persons = new List<Person>();
           persons.Add(new Person(){FirstName = "Michael", LastName = "Dm", Age = 23});
           persons.Add(new Person(){FirstName = "Michael", LastName = "Fg", Age = 32});
           persons.Add(new Person(){FirstName = "Michael", LastName = "Lon", Age = 34});
           persons.Add(new Person(){FirstName = "Michael", LastName = "Khai", Age = 21});

            var selected = from p in persons
                where p.Age <= 30
                select new {Name = String.Format("{0} {1}", p.FirstName, p.LastName), Age = p.Age};
            selected.ToList().ForEach(printLn);
        }

        /// extension used class StringExtender
        public void do_2()
        {
            string s = "Hi";
            s = s.RemoveSpaces();
            Console.WriteLine(s);

            int x = 5;
            x = x.Increment();
            Console.WriteLine(x);
        }
    }
    

    class Person
    {
        public string FirstName { get; set; } 
        public string LastName { get; set; } 
        public int Age { get; set; } 
    }

    static class StringExtender
    {
        static public string RemoveSpaces(this string str)
        {
            return "Hello";
        }

        static public int Increment(this int value)
        {
            return value + 1;
        }
    }
}
