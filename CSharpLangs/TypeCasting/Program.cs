using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TypeCasting
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Employee name");
            string name = Console.ReadLine();

            Console.WriteLine("Enter Employee Id");
            int id =Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Date of birth");
            DateTime dateOfBirth =Convert.ToDateTime(Console.ReadLine());

            //calculate age
            //1
            int age = DateTime.Now.Year - dateOfBirth.Year;
            //2
            DateTime today = new DateTime();
            int age1 = today.Year - dateOfBirth.Year;

            Console.WriteLine($"Age of Employee is {age}");
            //Console.WriteLine($"Age of Employee is {age1}");

            Console.Read();
        }
    }
}
