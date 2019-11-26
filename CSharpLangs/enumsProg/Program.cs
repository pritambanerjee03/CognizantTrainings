using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace enumsProg
{
    class Program
    {
        enum Color : byte
        {
            Red = 1,
            Green = 2,
            Blue = 4,
            Black = 0,
            white = Red | Green |Blue
        }
        static void Main(string[] args)
        {
            Color c = Color.Black;
            Console.WriteLine(c); //Black
            Console.WriteLine((byte)c); //0 Typecasting
            Console.ReadLine();
        }
    }
}
