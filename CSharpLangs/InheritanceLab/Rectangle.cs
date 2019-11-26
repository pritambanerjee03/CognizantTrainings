using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Rectangle : Drawing
    {
        int length, breadth;
        public Rectangle(int length, int breadth)
        {
            this.breadth = breadth;
            this.length = length;
        }
        public override void Area()
        {
            Console.WriteLine($"Area of the Reactangle with length {length} & breadth {breadth} " +
               $" is {breadth * length}");
        }
    }
}
