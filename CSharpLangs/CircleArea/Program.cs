using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircleArea
{
    class Program
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Enter the radius of the cicle");
            string input = Console.ReadLine();

            //validate
            double radius = 0;
            while (!double.TryParse(input, out radius))
            {
                Console.WriteLine("Not a valid radius enter a valid number again");
                input = Console.ReadLine();
            }

            //calculation
            if (radius < 0)
            {
                Console.WriteLine("radius can not be less than 1");
                return;
            }
            double area = Math.PI * radius * radius;
            Console.WriteLine($"The area of the circle {area}");

            
        }
    }
}
