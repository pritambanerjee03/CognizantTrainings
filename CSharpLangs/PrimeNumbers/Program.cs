using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            bool isPrime = true;
            int count = 0;
            Console.WriteLine("Prime Numbers : ");
            for (int i = 2; i <= 100; i++)
            {
                for (int j = 2; j <= 100; j++)
                {

                    if (i != j && i % j == 0)
                    {
                        isPrime = false;
                        break;
                    }

                }
                if (isPrime)
                {
                    Console.Write(i + " ");
                    count++;
                }
                isPrime = true;
            }

            Console.WriteLine($"\nTotal Prime numbers upto 100 is {count}");
        }
    }
}
