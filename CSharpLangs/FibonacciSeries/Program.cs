using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciSeries
{
    class Program
    {
        static void Main(string[] args)
        {
            int i, count, f1 = 0, f2 = 1, f3 = 0;
            Console.Write("Enter the Limit : ");
            count = Convert.ToInt32(Console.ReadLine());
            Console.Write(f1+" ");
            Console.Write(f2+" ");
            for (i = 0; i <count -2; i++)
            {
                f3 = f1 + f2;
                Console.Write(f3+ " ");
                f1 = f2;
                f2 = f3;
            }
            
        }
    }
}
