using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LamdaExpression
{
    class Program
    {
        static void Main(string[] args)
        {
            var points = new List<Point>()
            {
                new Point{X=12,Y=10,},
                new Point{X=0,Y=0,},
                new Point{X=-19,Y=50,},
                new Point{X=-40,Y=4,},
                new Point{X=8,Y=31,}
            };
            Console.WriteLine("Anonymous method - c# 2.0");
            var filteredPoints = points.FindAll(delegate (Point P)
            {
                return P.X > 0 && P.Y > 0;
            });

            foreach (var point in filteredPoints)
            {
                Console.WriteLine(point);
            }
            Console.WriteLine("Lamda Expression - c# 2.0");
            var filteredPoints2 = points.FindAll(p => p.X > 0 && p.Y > 0);
            

            foreach (var point in filteredPoints2)
            {
                Console.WriteLine(point);
            }
        }
    }
}
