using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLab
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Struct, AllowMultiple = true)]
    class AuthorAttribute: Attribute
    {
        //positional parameter (mandatory)
        private string name;
        //public read write fields or properties are named parameters
        public double Version { get; set; }
        public AuthorAttribute(string name)
        {
            this.name = name;
            Version = 1.1;
        }
        public string GetName()
        {
            return name;
        }
    }
}
