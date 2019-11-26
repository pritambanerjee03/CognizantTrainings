using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DelegateLab
{
    public delegate void WelcomeDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            WelcomeDelegate WelcomeDelegate = WelcomeMethod;

            WelcomeDelegate("param");
            Console.Read();
        }

        private static void WelcomeMethod(string name)
        {
            Console.WriteLine($"welcome {name}");
        }
    }
}
