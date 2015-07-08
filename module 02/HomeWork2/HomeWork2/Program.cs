using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    class Program
    {
        static byte X = 0;
        static byte O = 1;
        static uint boardSize = 8;
        static void Main(string[] args)
        {
            string line;
            byte startSymbol = 0;
            for (int i = 0; i < boardSize; i++)
            {
                line = "";
                if (i % 2 == 1) startSymbol = X; else startSymbol = O;
                byte currentCell = startSymbol;
                for (int n = 0; n < boardSize; n++)
                {
                    currentCell = invertCell(currentCell);
                    line += toString(currentCell);
                }
                Console.WriteLine(line);
            }
            Console.ReadKey();
        }

        static private byte invertCell(byte current)
        {
            if (current == X) return O; else return X;
        }

        static private string toString( byte currentCell){
            if (currentCell == X) return "X"; else return "O";
        }
    }
}
