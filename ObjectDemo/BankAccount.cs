using System;

namespace ObjectDemo;

public class BankAccount
{
    private string _accountName = "";
    private int _accountNumber = 0;

    private bool _isActive = false;

    private static int interestRate;

    public readonly int daysInWeek = 7;
    // Constructor
    public BankAccount(string accountName, int accountNumber)
    {
        // _accountName = accountName;
        // _accountNumber = accountNumber;
        if (accountName == "")
            _accountName = "Anonymous";
        else
            _accountName = accountName;
        _accountNumber = accountNumber;
    }

    public BankAccount(string accountName, int accountNumber, bool isActive)
    {
        _accountName = accountName;
        _accountNumber = accountNumber;
        _isActive = isActive;
    }

    public bool IsActive
    {
        get => _isActive;
        set => _isActive = value;
    }



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
