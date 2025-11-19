namespace LambdaDemo
{
    internal class Program
    {
        delegate string StringConverter(string value);
        static void Main(string[] args)
        {
            StringConverter converter = delegate (string value)
            {
                Console.Write("Inline conversion to lowercase > ");
                return value.ToLower();
            };
            var result = converter("This is some TEXT");
            Console.WriteLine(result);
        }
    }
}