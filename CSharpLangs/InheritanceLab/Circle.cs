using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceLab
{
    class Circle : Drawing
    {
        int radius;
        public Circle(int radius)
        {
            this.radius = radius;
        }
        public override void Area()
        {
            Console.WriteLine($"Area of the circle with radius {radius}" +
                $" is {Math.PI*radius*radius}");
        }
    }
}
