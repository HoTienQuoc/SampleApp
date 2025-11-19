using System;
namespace DelegateDemo
{

    internal class Program
    {
        delegate string StringConverter(string value);

        static string LowerCase(string value)
        {
            Console.Write("Converting to lowercase > ");
            return value.ToLower();
        }
        static string UpperCase(string value)
        {
            Console.Write("Converting to uppercase > ");
            return value.ToUpper();
        }
        static void Main(string[] args)
        {
            StringConverter converter1 = new(LowerCase);
            StringConverter converter2 = new(UpperCase);
            var lower = converter1("This is some TEXT");
            Console.WriteLine(lower);
            var upper = converter2("tHis IS sOmE TExt");
            Console.WriteLine(upper);
        }
    }
}