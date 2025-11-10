using System;
namespace ObjectDemo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // BankAccount custAccount;
            // custAccount = new BankAccount();
            // <--Alternative-->    
            // BankAccount custAccount = new BankAccount();
            // <--Alternative-->
            // BankAccount custAccount = new ();
            // custAccount.AccountName = "John Smith";
            // custAccount.AccountNumber = 53211;
            // <--Alternative-->

            // BankAccount custAccount = new BankAccount()
            // {
            //     AccountName = "John Smith",
            //     AccountNumber = 53211
            // };

            BankAccount custAccount = new BankAccount("Fred Wilson",
                        123456);

            Console.WriteLine($"Customer Name is {custAccount.AccountName}");

            Console.WriteLine($"Account Number = {custAccount.AccountNumber}");



            custAccount.DisplayName();

            Console.WriteLine($"Account Number = {custAccount.AccountNumber}");

            double maxBalance = BankAccount.GetMaxBalance();
            Console.WriteLine($"Maximum allowed balance = ${maxBalance}");

            BankAccount custAccount1 = new("John Smith", 53211);
            BankAccount custAccount2 = new("John Smith", 53211, true);
        }
    }
}