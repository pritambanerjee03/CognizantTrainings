using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Hashtable openWith = new Hashtable();
            openWith.Add(1, "One");
            openWith.Add(2, "Two");
            openWith.Add(3, "Three");
            openWith[4] = "Four";
            foreach (DictionaryEntry de in openWith)
            {
                Console.WriteLine($"Key = {de.Key}, Value={de.Value}");
            }
            ICollection valueCall = openWith.Values;
            Console.WriteLine("Values include: ");
            foreach (var v in valueCall)
            {
                Console.Write($"{v} ");
            }
            ICollection keyCall = openWith.Keys;
            Console.WriteLine();
            Console.WriteLine("Keys include: ");
            foreach (var k in keyCall)
            {
                Console.Write($"{k} ");
            }
            openWith.Remove(4);
            Console.WriteLine();
            if (!openWith.ContainsKey(4))
            {
                Console.WriteLine($"Key 4 is not found!");
            }
        }
    }
}
