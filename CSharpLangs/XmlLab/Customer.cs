﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace XmlLab
{
    class Customer
    {
        public int CustomerId { get; private set; }
        public string Name { get; set; }
        public string City { get; set; }

        public Customer(int customerid)
        {
            CustomerId = customerid;
        }

        public override string ToString()
        {
            return $"{CustomerId}\t{Name}\t{City}";
        }
    }
}
