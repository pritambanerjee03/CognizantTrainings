using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {
            string a, b;
            //validate
            Console.WriteLine("Enter the first number");
            a = Console.ReadLine();
            double input1 = 0;
            while (!double.TryParse(a, out input1))
            {
                Console.WriteLine("Not a valid number enter a valid number again");
                a = Console.ReadLine();
            }
            Console.WriteLine("Enter the operator(+,-,*,/)");
            string op = Console.ReadLine();
            while (!(op == "+" || op == "-" || op == "*" || op == "/"))
            {
                Console.WriteLine("Not a valid operator enter a valid number again");
                op = Console.ReadLine();

            }
            Console.WriteLine("Enter the second number");
            b = Console.ReadLine();
            double input2 = 0;
            while (!double.TryParse(b, out input2))
            {
                    Console.WriteLine("Not a valid number enter a valid number again");
                    b = Console.ReadLine();

            }

            //calculation
            switch (op)
            {
                case "+":
                    Console.WriteLine(input1 + input2);
                    break;
                case "-":
                    Console.WriteLine(input1 - input2);
                    break;
                case "*":
                    Console.WriteLine(input1 * input2);
                    break;
                case "/":
                    Console.WriteLine(input1 / input2);
                    break;
                default:
                    Console.WriteLine("Invalid operator");
                    break;
            }

        }
    }
}
