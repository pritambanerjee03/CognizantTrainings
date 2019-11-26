using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace XmlQueryFiles
{
    class Program
    {
        static void Main(string[] args)
        {
            XElement books = XElement.Parse(
                @"<books>
                <book>
                <title>Don Quixote</title>
                <author>Miguel de Cervantes</author>
                </book>
                <book>
                <title>Romeo and Juliet</title>
                <author>William Shakespeare</author>
                </book>
                <book>
                <title>The Game of Thrones</title>
                <author>George R.R Martin</author>
                </book>
                 </books>");
            var titles =
                from book in books.Elements("book")
                where book.Element("author").Value == "Miguel de Cervantes"
                select book.Element("title");

            foreach (var title  in titles)
            {
                Console.WriteLine(title.Value);
            }
            Console.Read();
        }
    }
}
