namespace LocalFunctions
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ConvertToEuros(100);
            for (int i = 1; i < 10; i++)
            {
                var factorial = FindFactorial(i);
                Console.WriteLine($"{i}! = {factorial}");
            }
        }
        private static void ConvertToEuros(double value)
        {
            var exchangeRate = 0.5;
            double USDToEuro(double dollars) => exchangeRate * dollars;
            var result = USDToEuro(value);
            Console.WriteLine(result);
        }
        private static int FindFactorial(int value)
        {
            int Factorial(int number)
            {
                // Base case
                if (number == 0)
                {
                    return 1;
                }
                // Recursive case
                return number * Factorial(number - 1);
            }
            return Factorial(value);
        }
    }
}