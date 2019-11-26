using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNoLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Real part for complex number1");
            string input = Console.ReadLine();
            int real1;
            while (!int.TryParse(input, out real1))
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter Real part for Imaginary number1");
            input = Console.ReadLine();
            int imaginary1;
            while (!int.TryParse(input, out imaginary1))
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
                input = Console.ReadLine();
            }

            ComplexNo complexNo1 = new ComplexNo(real1, imaginary1);

            Console.WriteLine("Enter Real part for complex number2");
            input = Console.ReadLine();
            int real2;
            while (!int.TryParse(input, out real2))
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
                input = Console.ReadLine();
            }

            Console.WriteLine("Enter Real part for Imaginary number2");
            input = Console.ReadLine();
            int imaginary2;
            while (!int.TryParse(input, out imaginary2))
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
                input = Console.ReadLine();
            }

            ComplexNo complexNo2 = new ComplexNo(real2, imaginary2);

            ComplexNo complexNo3 = complexNo1 + complexNo2;

            Console.WriteLine(complexNo3);
        }
    }
}
