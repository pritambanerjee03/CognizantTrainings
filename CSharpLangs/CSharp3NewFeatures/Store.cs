using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3NewFeatures
{
    class Store
    {
        public string Name { get; set; }
        public string City { get; set; }

        public override string ToString()
        {
            return $"{Name}\t{City}";
        }



    }
}
