using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiCastDelegate
{
    class MathOps
    {
        public static void Addition(int num1, int num2)
        {
            Console.WriteLine($"Addition of {num1} and {num2} "+
                $"is {num1+num2}");
        }
        public static void Subtraction(int num1, int num2)
        {
            Console.WriteLine($"Subtraction of {num1} and {num2} " +
                $"is {num1 - num2}");
        }
        public static void Multiply(int num1, int num2)
        {
            Console.WriteLine($"Multiply of {num1} and {num2} " +
                $"is {num1 * num2}");
        }
        public static void Division(int num1, int num2)
        {
            Console.WriteLine($"Division of {num1} and {num2} " +
                $"is {num1 / num2}");
        }
    }
}
