using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingExample
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string input = Console.ReadLine();

            //validate
            int number = 0;
            while(!int.TryParse(input, out number))
            {
                Console.WriteLine("Not a valid number enter a valid number again");
                input = Console.ReadLine();
            }
            //calculation
            if(number < 2)
            {
                Console.WriteLine($"{input} is  not prime");
                return;
            }
            bool isFlag = true;
            for (int i = 2; i < Math.Sqrt(number) ; i++)
            {
                if (number % i == 0)
                    isFlag = false;
            }
            if (isFlag)
            {
                Console.WriteLine($"{input} is prime");
            }
            else
            {
                Console.WriteLine($"{input} is not prime");
            }
        }
    }
}
