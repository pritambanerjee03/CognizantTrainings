using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLab
{
    class Program
    {
        static void Main(string[] args)
        {
            GenericClass<int> genericInt = new GenericClass<int>(10,20);
            Console.WriteLine($"Addition Result = "+
                $"{genericInt.param1 + genericInt.param2}");

            GenericClass<string> genericString = new GenericClass<string>("Hello", "CTS");
            Console.WriteLine($"String Concat Result is "+
                $"{genericString.param1 + genericString.param2}");
        }
    }
}
