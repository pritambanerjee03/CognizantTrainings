using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkLab
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = { "Bruce", "Aony", "Pritam", "Bwink", "Cahul","Steve","Banner",
            //                    "Steven","Aeorge","Btark","kimra"};
            //var result = from m in names
            //             where m.Length == 5
            //             select m.ToUpper();

            //var result = names.Where(n => n.Length == 5).Select(n => n.ToUpper());

            //var result = from m in names
            //             where m.StartsWith("A") || m.StartsWith("B")
            //             select m.ToUpper();

            //var result = names.Where(n => n[0] == 'A' || n[0] == 'B')
            //            .OrderByDescending(n=>n)
            //            .Select(n => n.ToUpper());

            //foreach (var name in result)
            //{
            //    Console.WriteLine(name);
            //}

            List<string> msg = new List<string> { "hello world", "hello LinQ", "adios LinQ" };
            var result = from m in msg
                         where m.EndsWith("LinQ")
                         select m;
            foreach (var item in result)
                {
                    Console.WriteLine(item);
                }


           

                Console.Read();
        }
    }
}
