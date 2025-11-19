using System;
namespace DelegateDemo
{

    internal class Program
    {
        public delegate string MyDelegate(string s);
        public static string GetLength(string s)
        {
            return "Length of the string is: " + s.Length;
        }

        public static string CustomerCount(string customer)
        {
            return "Total Customers: 100";
        }
        static void Main(string[] args)
        {

            MyDelegate delegate1 = new MyDelegate(GetLength);
            MyDelegate delegate2 = new MyDelegate(CustomerCount);

            var strlen = delegate1("This is some text");
            var count = delegate2("Robert Addison");

            Console.WriteLine(strlen);
            Console.WriteLine(count);
        }
    }
}