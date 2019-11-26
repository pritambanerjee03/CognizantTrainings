using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HellloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello World!");
            Console.WriteLine("Enter your Name ");
            string name = Console.ReadLine();
            Console.WriteLine("Welcome " + name + " to Cognizant");
            Console.WriteLine(string.Format("Hello {0},  Welcome to CTS!", name));
            Console.WriteLine($"Hello {name},  Welcome to CTS!");

        }
    }
}
