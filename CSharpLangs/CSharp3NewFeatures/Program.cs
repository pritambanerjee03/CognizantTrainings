using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp3NewFeatures
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
        static List<Store> GetStores()
        {
            var stores = new List<Store>()
            {
                new Store{ Name="Pizza", City = "Chennai"},
                new Store{ Name="Chicken", City = "Mumbai"},
                new Store{ Name="Kaju Barfi", City = "Kolakta"},
                new Store{ Name="Mutton", City = "kochi"}

            };
            return stores;
           
        }

        static List<Customer> FindCustomersByCity(string city)
        {
            var customers = GetCustomers().FindAll(c => c.City == city);
            return customers;
        }
        static void Main(string[] args)
        {
            string num = "123";
            int result = num.ToNumber(); 
            Console.WriteLine(result);

            //Customer customer = new Customer(1);
            ////customer.CustomerId = 1;
            //customer.Name = "Param";
            //customer.City = "Chennai";

            Customer customer = new Customer(5)
            {
                Name = "Sweta",
                City = "Chennai"
            };

            //   Console.WriteLine(customer);

            foreach (var c in GetCustomers())
            {
                if (customer.Compare(c))
                {
                    Console.WriteLine("Customer already exists");
                }
                else
                {
                    Console.WriteLine(c);
                }
            }

            //append another list
           //var CustomerList = GetCustomers();
            var newList = new List<Customer>()
            {
                new Customer(1){Name= "Pritam", City="Kolkata"},
                new Customer(2){Name= "Tamasa", City="Burdwaan"},

            };

            var CustomerList = GetCustomers().Append(newList);

            foreach (var cust in CustomerList)
            {
                Console.WriteLine(cust);
            }

            Console.WriteLine("Number of Stores in Chennai");
            var storeList = GetStores();
            var storeCount = (from s in storeList
                             where s.City == "Chennai"
                             select s).Count();
            Console.WriteLine(storeCount);

            var customerStores = from c in GetCustomers()
                                 select new
                                 {
                                     c.Name,
                                     c.City,
                                     Stores = from s in GetStores()
                                              where s.City == c.City
                                              select s
                                 };
            Console.WriteLine("Customer with city info");
            foreach (var c in customerStores)
            {
                Console.WriteLine($"{c.Name}\t{c.City}");
                foreach (var s in c.Stores)
                {
                    Console.WriteLine($"\tStore Name: {s.Name}");
                }
            }
        }
                         
    }
}
