using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeekDaya
{
   
    class Program
    {
        
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a Number");
            string input = Console.ReadLine();

            //validate
            int number = 0;
            while (!int.TryParse(input, out number))
            {
                Console.WriteLine("Not a valid number enter a valid number again");
                input = Console.ReadLine();
            }
            WeekDays weekDays = (WeekDays)number;
            switch (weekDays)
            {
                case WeekDays.Sunday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                case WeekDays.Monday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                case WeekDays.Tuesday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                case WeekDays.Wednesday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                case WeekDays.Thursday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                case WeekDays.Friday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                case WeekDays.Saturday:
                    Console.WriteLine($"Day of week is {weekDays}");
                    break;
                default:
                    Console.WriteLine($"Not a valid number");
                    break;
            }
        }
    }
}
