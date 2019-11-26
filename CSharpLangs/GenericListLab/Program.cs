using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> list = new List<string>();
            Console.WriteLine(list.Capacity);
            list.Add("Palak Paneer");
            list.Add("Chicken Tikka");
            list.Add("Rasogolla");
            list.Add("Fish Kalia");
            list.Add("Fish Fry");
            Console.WriteLine(list.Capacity);
            foreach (object item in list)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
            list.Clear();
            Console.WriteLine(list.Capacity);
            Console.WriteLine(list.Count);
        }
    }
}
