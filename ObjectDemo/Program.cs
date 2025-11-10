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

            BankAccount custAccount = new BankAccount()
            {
                AccountName = "John Smith",
                AccountNumber = 53211
            };

            Console.WriteLine($"Customer Name is {custAccount.AccountName}");

            Console.WriteLine($"Account Number = {custAccount.AccountNumber}");

            custAccount.DisplayName();

            Console.WriteLine($"Account Number = {custAccount.AccountNumber}");

            double maxBalance = BankAccount.GetMaxBalance();
            Console.WriteLine($"Maximum allowed balance = ${maxBalance}");
        }
    }
}