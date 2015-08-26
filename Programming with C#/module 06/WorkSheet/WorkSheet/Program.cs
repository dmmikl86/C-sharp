using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WorkSheet
{
    class Program
    {
        static void Main(string[] args)
        {
            using (Calculator calculator = new Calculator())
            {
                Debug.WriteLine("{0}/{1}={2}", 120, 5, calculator.Divide(120, 5));
            }
            Debug.WriteLine("Program finishing");
        }
    }
}
