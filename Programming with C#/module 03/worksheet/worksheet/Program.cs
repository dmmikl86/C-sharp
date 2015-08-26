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
#region Methods
            /*int first = 24;
            string sValue;
            string tValue = "";
            int first34;
            ReturnMultiOut(out first34, out sValue, tValue);

            sValue = "";
            ReturnMultiRef(ref first, ref sValue);
            Console.WriteLine("{0} {1}", first.ToString(), sValue);

            Console.WriteLine("{0}, {1}", first.ToString(), sValue);

            StopService(true, tValue);

            // The method can be called in the normal way, by using positional arguments.
            Console.WriteLine(CalculateBMI(123, 64));

            // Named arguments can be supplied for the parameters in either order.
            CalculateBMI(height: 3);

            StopService(true, serviceId: 1);*/
#endregion


            Console.ReadKey();
        }

        static void ReturnMultiOut(out int i, out string s, string st)
        {
            i = 25;
            s = "using out";
            st = "tValue";

        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = i + 2;
            s = "using ref";
        }

        static void StopService(bool forceStop, string serviceName = null, int serviceId = 1)
        {
            // code here that will stop the service
        }

        static int CalculateBMI(int weight = 5, int height = 6)
        {
            return (weight * 703) / (height * height);
        }
    }
}
