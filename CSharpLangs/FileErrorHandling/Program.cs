using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileErrorHandling
{
    class Program
    {
        static void Main(string[] args)
        {
            //file writing
            try
            {
                using (FileStream stream = new FileStream(@"E:\amar-api\amar-api1.txt",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamWriter writer = new StreamWriter(stream))
                    {
                        writer.WriteLine("Hello");
                        writer.WriteLine("Pritam");

                        Console.WriteLine("File write Complete");
                    }
                }

            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }

            //file read
            try
            {
                using (FileStream stream = new FileStream(@"E:\amar-api\amar-api1.txt",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    using (StreamReader reader = new StreamReader(stream))
                    {
                        Console.WriteLine(reader.ReadToEnd());
                        Console.WriteLine("File read Complete");
                    }
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
        }
    }
}
