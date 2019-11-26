using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EventLab
{
    class Program
    {
        static void Main(string[] args)
        {
            ButtonClass button = new ButtonClass();
            button.ButtonClicked += ClickHandler;

            button.SimulateClick();

        }

        private static void ClickHandler()
        {
            Console.WriteLine("EvenT Handled");
        }
    }
}
