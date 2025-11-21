namespace InheritanceDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SavingsAccount account = new(accountName: "John Smith", accountNumber: 12312, accountBalance: 1000.99, interestRate: 0.05);
            Console.WriteLine($"Interest earned this month = {account.MonthlyInterest()}");
            account.DisplayName();
        }
    }
}