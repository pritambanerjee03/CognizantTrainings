using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("In main: Strating Thread");
            Thread childThread = new Thread(ChildMethod);
            childThread.Name = "Child Thread";
            childThread.Start();

            Thread.Sleep(3000);
            Console.WriteLine("Aborting Child Thread");
            childThread.Abort();
            Console.WriteLine("In main: child thread aborted");
            Console.Read();

        }

        private static void ChildMethod()
        {
            try
            {
                Console.WriteLine("Child Thread strats");
                for (int counter = 0; counter <= 10; counter++)
                {
                    Thread.Sleep(500);
                    Console.WriteLine(counter);
                }
                Console.WriteLine("Child Thread Completed");
            }
            catch (ThreadAbortException e)
            {

                Console.WriteLine("Thread Abort Exception");
            }
            finally
            {
                Console.WriteLine("Couln't catch the thread exception");
            }
        }
    }
}
