using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IteratorLab
{
    class DaysOfWeek : IEnumerable
    {
        string[] days = { "Sun", "Mon", "Tue", "Wed", "Thu", "Fri", "Sat" };

        public IEnumerator GetEnumerator()
        {
            for (int index = 0; index < days.Length; index++)
            {
                yield return days[index];
            }
        }
    }
}
