using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComplexNoLab
{
    class ComplexNo
    {
        int real, imaginary;
        public ComplexNo(int real, int imaginary)
        {
            this.real = real;
            this.imaginary = imaginary;
        }

        public static ComplexNo operator + (ComplexNo c1, ComplexNo c2)
        {

            /*  c1.real = c1.real + c2.real;
              c1.imaginary = c1.imaginary + c2.imaginary;
              return c1;*/

            return new ComplexNo(c1.real + c2.real, c1.imaginary + c2.imaginary);
        }

        public override string ToString()
        {
            return $"After adding {real} + {imaginary}!";
        }
    }
}
