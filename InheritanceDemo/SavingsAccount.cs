using System;

namespace InheritanceDemo;

public class SavingsAccount : BankAccount
{
    private double _interestRate;

    public SavingsAccount(
        string accountName, int accountNumber, double accountBalance,
        double interestRate)
        : base(accountName, accountNumber, accountBalance)
    {
        _interestRate = interestRate;
    }
    public double InterestRate
    {
        get => _interestRate;
        set => _interestRate = value;
    }

    public double MonthlyInterest()
    {
        return (_interestRate * AccountBalance) / 12;
    }
    public override void DisplayName()
    {
        base.DisplayName();
        Console.WriteLine($"Account is earning {InterestRate}%interest.");
    }

}
