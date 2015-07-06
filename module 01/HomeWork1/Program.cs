using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork1
{
    class Program
    {
        static void Main(string[] args)
        {
            string firstName = "Michael";
            string lastName = "Smit";
            DateTime birthdate = DateTime.Parse("27.09.1986");
            string addressLine1 = "Hm.Street 75/52";
            string addressLine2 = "Space 7/27";
            string city = "Vinnitsa";
            string state = "Vinn";
            int zipCode = 21021;
            string country = "Ukraine";

            Console.WriteLine("firstName: {0}",firstName);
            Console.WriteLine(lastName);
            Console.WriteLine(birthdate);
            Console.WriteLine(addressLine1);
            Console.WriteLine(addressLine2);
            Console.WriteLine(city);
            Console.WriteLine(state);
            Console.WriteLine(zipCode);
            Console.WriteLine(country);
            Console.ReadLine(); // this line will not close console
        }
    }
}
