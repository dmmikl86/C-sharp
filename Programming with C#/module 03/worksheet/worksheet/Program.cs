using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace worksheet
{
    class Program
    {
        static void Main(string[] args)
        {

            Irt i = new Irt(5);
            int res = i + 5;
            Console.WriteLine(res);
        }


        class Irt
        {
            public int n;
            public Irt(int n)
            {
                this.n = n;
            }


            public static int operator + (Irt i, int n){
                return i.n + n;        
            }
        }
    }
}
