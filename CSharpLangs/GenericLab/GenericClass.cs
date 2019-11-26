using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericLab
{
    class GenericClass<T>
    {
        public T param1;
        public T param2;
        public GenericClass(T param1, T param2)
        {
            this.param1 = param1;
            this.param2 = param2;
        }
    }
}
