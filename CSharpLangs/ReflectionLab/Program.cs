using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionLab
{
    class Program
    {
        static void Main(string[] args)
        {
            Assembly info = typeof(System.Int32).Assembly;
            Console.WriteLine(info.FullName);

            Assembly assembly = Assembly.GetExecutingAssembly();
            ShowAssemblyName(assembly);
            ShowAssemblyTypes(assembly);
        }

        private static void ShowAssemblyTypes(Assembly a)
        {
            Type[] types = a.GetTypes();
            foreach (Type type in types)
            {
                Console.WriteLine(types);
                ShowMethods(type);
            }
        }

        private static void ShowMethods(Type type)
        {
            MethodInfo[] methodInfo = type.GetMethods();
            foreach (MethodInfo m in methodInfo)
            {
                Console.WriteLine("\tMethod Name: {0}",m.Name);
            }
        }

        private static void ShowAssemblyName(Assembly a)
        {
            Console.WriteLine("assembly name= {0}",a.FullName);
        }
    }
}
