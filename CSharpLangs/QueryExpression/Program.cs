using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueryExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var numbers = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach (var number in numbers)
            {
                if(number%2 == 0)
                {
                    //even numbers
                }
            }

            var evenNumbers = from n in numbers
                              where n % 2 == 0
                              select n;
            Console.WriteLine("Even number using LinQ query");
            foreach (var num in evenNumbers)
            {
                Console.WriteLine(num);
            }

            var evenNumbers2 = numbers.Where(n => n % 2 == 0);
            Console.WriteLine("Even number using Lamda/method query");
            foreach (var num in evenNumbers2)
            {
                Console.WriteLine(num);
            }

        }
    }
}
