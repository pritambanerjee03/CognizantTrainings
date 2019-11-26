using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList list = new ArrayList();
            list.Add(1);
            list.Add("Hello");
            list.Add(new DateTime(1990, 6, 14));

            foreach(object item  in list)
            {
                Console.WriteLine(item);
            }

        }
    }
}
