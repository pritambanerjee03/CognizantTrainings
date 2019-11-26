using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string input = Console.ReadLine();
            Console.WriteLine("Enter a Digit to check ");
            string digitCheck = Console.ReadLine();

            //validate
            int number = 0, digit = 0;
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Not a valid number enter a valid number again");
                input = Console.ReadLine();
            }
            while (!int.TryParse(digitCheck, out digit))
            {
                Console.WriteLine("Not a valid number enter a valid digit");
                digitCheck = Console.ReadLine();
            }
            //calculation
            int sum = 0, count=0, no=number , product = 1;
            bool isPresent = false;
            while(number>0)
            {
                int rem = number % 10;
                if(rem == digit)
                {
                    isPresent = true;
                }
                count++;
                product *= rem;

                if(rem%2 == 0)
                {
                    Console.WriteLine($"{rem} is an even digit");
                }
                else
                {
                    Console.WriteLine($"{rem} is an odd digit");
                }
                sum = rem + sum * 10;
                number /= 10;
            }
            
            Console.WriteLine($"Reverse number {sum}, No of digits {count}");

            if (isPresent)
            {
                Console.WriteLine($"{digit} is present in {no}");
            }
            else
            {
                Console.WriteLine($"{digit} is not present in {no}");
            }

            Console.WriteLine($"Product of the digits {no}, is {product}");
        }
    }
}
