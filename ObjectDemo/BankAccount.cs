using System;

namespace ObjectDemo;

public class BankAccount
{
    private string _accountName = "";
    private int _accountNumber = 0;

    private static int interestRate;

    public readonly int daysInWeek = 7;

    public string AccountName
    {
        get => _accountName;
        set => _accountName = value;
    }

    public int AccountNumber
    {
        get => _accountNumber;
        set => _accountNumber = value;
    }

    public void DisplayName()
    {
        Console.WriteLine($"Customer name is {AccountName}");
    }

    public static double GetMaxBalance()
    {
        return (10000000.00);
    }
}
