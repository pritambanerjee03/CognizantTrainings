using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AttributeLab
{
    class Program
    {
        static void Main(string[] args)
        {
            DisplayAuthorInfo(typeof(BookNoAuthor));
            DisplayAuthorInfo(typeof(BookSingleAuthor));
            DisplayAuthorInfo(typeof(BookMultiAuthor));
            Console.Read();

        }

        private static void DisplayAuthorInfo(Type type)
        {
            Console.WriteLine("Author Information for {0}",type);
            //using reflection
            Attribute[] attrs = Attribute.GetCustomAttributes(type);

            //Diplaying Output
            foreach (Attribute attr in attrs)
            {
                if(attr is AuthorAttribute) //check type of attribute
                {
                    AuthorAttribute a = (AuthorAttribute)attr;
                    Console.WriteLine("Author name {0}, version {1:f}",
                        a.GetName(), a.Version);
                }
            }
        }
    }
}
