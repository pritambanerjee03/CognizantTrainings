using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExceptionHandling
{
    class ArrayClass
    {
        int[] arr;
        public ArrayClass(int size)
        {
            arr = new int[size];
        }
        public int GetItem(int index)
        {
            try
            {
                return arr[index];
            }
            catch (IndexOutOfRangeException ex)
            {

                // Console.WriteLine("index was out of range");
                // Console.WriteLine(ex.Message);
                // return 0;
                throw new InvalidIndexException("Index out of Range");
            }
            finally
            {
                Console.WriteLine("Inside finally block");
            }
        }
    }
}
