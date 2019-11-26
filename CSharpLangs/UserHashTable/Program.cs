using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UserHashTable
{
    class Program
    {
        static void Main(string[] args)
        {
            {
                Hashtable openWith = new Hashtable();
                openWith.Add(1, "Amal");
                openWith.Add(2, "Vimal");
                openWith.Add(3, "Sham");
                openWith[4] = "Ram";
                foreach (DictionaryEntry de in openWith)
                {
                    Console.WriteLine($"Key = {de.Key}, Value={de.Value}");
                }
                
                Console.WriteLine("Enter a number");
                int id = Convert.ToInt32(Console.ReadLine());
                
                if (openWith.ContainsKey(id))
                {
                    Console.WriteLine($"Key {id} is found with name {openWith[id]}");
                }else
                {
                    Console.WriteLine($"Key {id} is not found");
                }

            }
        }
    }
}
