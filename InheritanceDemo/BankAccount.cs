using System;

namespace InheritanceDemo;

public class BankAccount
{
    private string _accountName;
    private int _accountNumber;
    private double _accountBalance;

    public BankAccount(string accountName, int accountNumber, double accountBalance)
    {
        _accountName = accountName;
        _accountNumber = accountNumber;
        _accountBalance = accountBalance;
    }

    public double AccountBalance
    {
        get => _accountBalance;
        set => _accountBalance = value;
    }
}
