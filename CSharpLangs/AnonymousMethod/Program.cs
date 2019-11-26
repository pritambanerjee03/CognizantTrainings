using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnonymousMethod
{
    public delegate void WelcomeDelegate(string name);
    class Program
    {
        static void Main(string[] args)
        {
            //WelcomeDelegate welcomeDelegate = new WelcomeDelegate(WelcomeMethod);

            WelcomeDelegate welcomeDelegate2 = WelcomeMethod;
            welcomeDelegate2("CTS");
        }

        private static void WelcomeMethod(string name)
        {
            Console.WriteLine($"Hello {name}");
        }
    }
}
