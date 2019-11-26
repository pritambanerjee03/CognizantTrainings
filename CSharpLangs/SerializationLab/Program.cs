using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;

namespace SerializationLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book
            {
                BookId = 1,
                Name = "Song of Ice and Fire",
                Author = "Grrm",
                Price = 1500
            };
            //SerializeBinary(book);
            //SerializeXML(book);
            DeserializeXml();
            Console.Read();
        }

      /*  private static void SerializeBinary(Book book)
        {
            try
            {
                using (FileStream stream =new FileStream(@"E:\amar-api\amar-api2.txt",
                    FileMode.OpenOrCreate, FileAccess.ReadWrite))
                {
                    var formatter = new BinaryFormatter();
                    var data = formatter.Deserialize(stream);

                    if(data is Book) //type check
                    {
                        var book1 = data as Book;
                        Console.WriteLine("Book Deserialized");
                        Console.WriteLine($"Book Id: {book1.BookId}\n"+
                            $"Name: {book1.Name}\nAuthor:{book1.Author}\n"+
                            $"Price: {book1.Price}");
                    }
                    formatter.Serialize(stream, book);

                    Console.WriteLine("Binary Serialization Done");
                }
            }
            catch (IOException ex)
            {

                Console.WriteLine(ex.Message);
            }
        } */
        private static void SerializeXML(Book book)
        {
            try
            {
                using (var writer = XmlWriter.Create(new FileStream(@"E:\amar-api\amar-api2.xml",
                    FileMode.OpenOrCreate, FileAccess.Write)))
                {
                    var serializer = new XmlSerializer(typeof(Book));
                    serializer.Serialize(writer, book);
                    Console.WriteLine("XML serialization done");
                }

            }
            catch (IOException ex)
            {

                Console.WriteLine($"Error:{ ex.Message}");
            }
        }
        public static void DeserializeXml()
        {
            try
            {
                using (var stream =new FileStream(@"E:\amar-api\amar-api2.xml",
                    FileMode.Open,FileAccess.Read))
                {
                    var serializer = new XmlSerializer(typeof(Book));
                    var data = serializer.Deserialize(stream);

                    if(data is Book) //type check
                    {
                        var book1 = data as Book;
                        Console.WriteLine("Book deserialized.");
                        Console.WriteLine($"Book Id: {book1.BookId}\n" +
                            $"Name: {book1.Name}\nAuthor:{book1.Author}\n" +
                            $"Price: {book1.Price}");
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

