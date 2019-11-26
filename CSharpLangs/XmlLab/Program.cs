using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace XmlLab
{
    class Program
    {
        static List<Customer> GetCustomers()
        {
            var customers = new List<Customer>()
            {
                new Customer(1){ Name="Param", City = "Chennai"},
                new Customer(2){ Name="Amit", City = "Mumbai"},
                new Customer(3){ Name="Raju", City = "Kolakta"},
                new Customer(4){ Name="anamika", City = "kochi"}

            };
            return customers;
        }
        static void Main(string[] args)
        {

            var filePath = @"E:\amar-api\customers1.xml";
            /* try
             {
                 using (XmlWriter writer = XmlWriter.Create(filePath))
                 {
                     writer.WriteStartDocument();
                     writer.WriteStartElement("Customers");

                     foreach (var customer in GetCustomers())
                     {
                         writer.WriteStartElement("Customer");
                        //nodes
                        writer.WriteElementString("CustomerId", customer.CustomerId.ToString());
                        writer.WriteElementString("Name", customer.Name);
                        writer.WriteElementString("City", customer.City);

                        //attributes
                        //writer.WriteAttributeString("CustomerId", customer.CustomerId.ToString());
                        // writer.WriteAttributeString("Name", customer.Name);
                        // writer.WriteAttributeString("City", customer.City);

                         writer.WriteEndElement();
                     }
                     writer.WriteEndElement();
                     writer.WriteEndDocument();
                 }
             }
             catch (Exception ex)
             {

                 Console.WriteLine(ex.Message); ;
             }
             Console.Read(); */

            ReadCustomerXmlFile(filePath);
            Console.Read();
        }

        private static void ReadCustomerXmlFile(string filePath)
        {
            XmlDocument document = new XmlDocument();
            try
            {
                document.Load(filePath);
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }
            var customerNodes = document.GetElementsByTagName("Customer");

            foreach (XmlNode customer in customerNodes)
            {
                //data in attributes
                if (customer.Attributes.Count > 0)
                {
                    foreach (XmlAttribute attr in customer.Attributes)
                    {
                        Console.WriteLine($"{attr.Name} : {attr.InnerText}");
                    }
                }
                //data in nodes
                else
                {
                    foreach (XmlNode attr in customer.ChildNodes)
                    {
                        Console.WriteLine($"{attr.Name} : {attr.InnerText}");
                    }
                }
            }
        }
    }
}
