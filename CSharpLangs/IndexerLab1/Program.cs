using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexerLab1
{
    class Program
    {
        static void Main(string[] args)
        {
            IndexNames names = new IndexNames(10);
            names[0] = "Ram";
            names[1] = "Sham";
            names[2] = "Jadhu";
            names[3] = "Madhu";
            names[4] = "Simran";
            names[5] = "Ani";

            for (int i = 0; i < names.Size; i++)
            {
                Console.WriteLine($"Name : {names[i]}");
            }

        }
    }
}
