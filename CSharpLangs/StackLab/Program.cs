using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Stack stack = new Stack();
            stack.Push("old");
            stack.Push(1);
            stack.Push(new DateTime(1990, 06, 12));
            Console.WriteLine("Objects in stack");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Poped element {stack.Pop()}");
            Console.WriteLine($"Poped element {stack.Pop()}");
            //Console.WriteLine($"Poped element {stack.Pop()}");

           Console.WriteLine($"Peeked element {stack.Peek()}");
            stack.Push(5);
            Console.WriteLine("Objects in stack");
            foreach (object item in stack)
            {
                Console.WriteLine(item);
            }
        }
    }
}
