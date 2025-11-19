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
        static void DisplayText(StringConverter converter, string text)
        {
            string result = converter(text);
            Console.WriteLine($"Converted text = {result}");
        }
        static void Main(string[] args)
        {
            StringConverter converter1 = new(LowerCase);
            StringConverter converter2 = new(UpperCase);
            var lower = converter1("This is some TEXT");
            Console.WriteLine(lower);
            var upper = converter2("tHis IS sOmE TExt");
            Console.WriteLine(upper);

            StringConverter multicast = converter1 + converter2;
            var result = multicast("This is some TEXT");
            Console.WriteLine(result);

            StringConverter multicast1 = converter1 + converter2;
            var result1 = multicast1("This is some TEXT");
            Console.WriteLine(result1);
            multicast1 -= converter2;
            result1 = multicast1("AfTeR reMovAL oF converter2");
            Console.WriteLine(result1);

            DisplayText(converter1, "This IS a teST.");
        }
    }
}