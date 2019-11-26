using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SpecialDelgate
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string> welcome = (name) =>
            {
                Console.WriteLine($"Hello {name}");
            };
            welcome("param");

            Func<string, string, string> getName = (firstname, lastname) =>
            {
                return $"Hello {firstname} {lastname}";
            };
            var name1 = getName("Param", "Singh");
            Console.WriteLine(name1);
            Console.Read();
        }
    }
}
