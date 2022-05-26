using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReflectionDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to reflection Demo");
            CustomerInfo obj = new CustomerInfo();
            ReflectionOnCustomer.ReflectionTest();
            obj.Id = -2;
            Console.WriteLine(obj.Id);
            Console.ReadKey();
        }
    }
}
