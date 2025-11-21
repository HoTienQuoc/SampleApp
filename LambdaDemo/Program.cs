namespace LambdaDemo
{
    internal class Program
    {
        delegate string StringConverter(string value);

        delegate string StringConverter1(string value);

        static void DisplayText(StringConverter converter, string text)
        {
            string result = converter(text);
            Console.WriteLine($"Converted text = {result}");
        }

        static void Main(string[] args)
        {
            StringConverter converter = delegate (string value)
            {
                Console.Write("Inline conversion to lowercase > ");
                return value.ToLower();
            };
            var result = converter("This is some TEXT");
            Console.WriteLine(result);

            DisplayText(converter, "This IS a teST.");

            StringConverter converter3 = s => s.ToLower();
            var result2 = converter3("LAMBDA Demo");
            Console.WriteLine(result2);

        }
    }
}