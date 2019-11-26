using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayProg
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter how many values");
            int n = Convert.ToInt32(Console.ReadLine());

            int[] arr = new int[n];

            for (int index = 0; index < n; index++)
            {
                Console.WriteLine("Enter number "+(index+1));
                arr[index] = Convert.ToInt32(Console.ReadLine());
            }

            //Display Using For loop
            for (int index = 0; index < n; index++)
            {
                Console.Write(arr[index]+" ");
            }
            Console.WriteLine("\nnext print");
            //display using for each

            foreach (var item in arr)
            {
                Console.Write(item+"  ");
            }
        }
    }
}
