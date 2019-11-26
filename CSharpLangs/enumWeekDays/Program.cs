using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumWeekDays
{
    class Program
    {
     
        static void Main(string[] args)
        {
            DaysOfWeek daysOfWeek = DaysOfWeek();

            switch (daysOfWeek)
            {
                case DaysOfWeek.Sunday:
                    break;
                case DaysOfWeek.Monday:
                    break;
                case DaysOfWeek.Tuesday:
                    break;
                case DaysOfWeek.Wednesday:
                    break;
                case DaysOfWeek.Thursday:
                    break;
                case DaysOfWeek.Friday:
                    break;
                case DaysOfWeek.Saturday:
                    break;
                default:
                    break;
            }
        }
    }
}
