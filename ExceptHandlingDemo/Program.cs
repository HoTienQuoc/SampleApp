
namespace ExceptHandlingDemo
{
    internal class Program
    {
        private static int motorTemp;

        static void Main(string[] args)
        {
            try
            {
                VoltageCheck(501);
            }
            catch (ArgumentOutOfRangeException ex)
            {
                Console.WriteLine("Voltage too high - disconnecting power");
                Console.WriteLine(ex.Message);
                if (ex is ArgumentOutOfRangeException)
                {
                    Console.WriteLine(ex.Message);
                }
                else if (ex is NullReferenceException)
                {
                    Console.WriteLine(ex.Message);
                }
            }
            try
            {
                VoltageCheck(501);
            }
            catch (Exception ex) when (ex is ArgumentOutOfRangeException &&
            motorTemp > 102)
            {
            }

            try
            {
                VoltageCheck(501);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine("Resetting system.");
            }
        }

        private static void VoltageCheck(int voltage)
        {
            if (voltage > 500)
                throw new ArgumentOutOfRangeException(nameof(voltage),
                "Voltage exceeds safety parameters.");
            else
                Console.WriteLine("Voltage is safe.");
        }
    }
}