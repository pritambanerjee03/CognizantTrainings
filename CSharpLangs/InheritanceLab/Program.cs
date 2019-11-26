using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter 1.Circle 2.Rectangle");
            string input = Console.ReadLine();
            int result;
            while(!int.TryParse(input, out result))
            {
                Console.WriteLine("Invalid Input, Enter Valid Number");
                input = Console.ReadLine();
            }

            if(result == 1)  //circle
            {
                Console.WriteLine($"Enter radius");
                input = Console.ReadLine();
                int radius;
                while (!int.TryParse(input, out radius))
                {
                    Console.WriteLine("Invalid radius, Enter Valid Radius");
                    input = Console.ReadLine();
                }

                Circle circle = new Circle(radius);
                circle.Area();
            }

            else if (result == 2)  //rectangle
            {
                Console.WriteLine($"Enter length");
                input = Console.ReadLine();
                int length;
                while (!int.TryParse(input, out length))
                {
                    Console.WriteLine("Invalid length, Enter Valid Length");
                    input = Console.ReadLine();
                }

                Console.WriteLine($"Enter breadth");
                input = Console.ReadLine();
                int breadth;
                while (!int.TryParse(input, out breadth))
                {
                    Console.WriteLine("Invalid breadth, Enter Valid Breadth");
                    input = Console.ReadLine();
                }
                Rectangle rectangle = new Rectangle(length, breadth);
                rectangle.Area();

            }
        }
    }
}
