using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLab
{
    class Program 
    {
        static void Main(string[] args)
        {
            DaysOfWeek daysOfWeek = new DaysOfWeek();
            foreach (string day in daysOfWeek)
            {
                Console.WriteLine(day);
            }
            Console.ReadLine();
        }
        
    }
}
