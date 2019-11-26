using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableType
{
    class Program
    {
        static void Main(string[] args)
        {
            int? i = null;
            int j = i ?? 40; //null coalese operator
            j = i.GetValueOrDefault();
            if(i.HasValue)
            {

            }
            if(i == null)
            {

            }
        }
    }
}
