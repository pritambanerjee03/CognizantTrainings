using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QueueLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue queue = new Queue();
            queue.Enqueue("old");
            queue.Enqueue(1);
            queue.Enqueue(new DateTime(1990, 06, 12));
            Console.WriteLine("Objects in queue");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"Dequed element {queue.Dequeue()}");
            Console.WriteLine($"Dequed element {queue.Dequeue()}");
            

            queue.Enqueue(5);
            Console.WriteLine("Objects in queue");
            foreach (object item in queue)
            {
                Console.WriteLine(item);
            }
        }
    }
}
