using System;

namespace BankApp;

    // Base class for bank accounts
    // public class Account
    // {
    //     public string AccountNumber { get; }
    //     public decimal Balance { get; protected set; }
    //     public string Owner { get; }

    //     public Account(string accountNumber, string owner)
    //     {
    //         AccountNumber = accountNumber;
    //         Owner = owner;
    //         Balance = 0.0M;
    //     }

    //     public virtual void Deposit(decimal amount)
    //     {
    //         Balance += amount;
    //     }

    //     public virtual bool Withdraw(decimal amount)
    //     {
    //         if (amount <= Balance)
    //         {
    //             Balance -= amount;
    //             return true;
    //         }
    //         return false;
    //     }

    // }

   public abstract class Account
{
    public string AccountNumber { get; }
    public string Owner { get; set; }
    public decimal Balance { get; set; }

    public Account(string accountNumber, string owner)
    {
        AccountNumber = accountNumber;
        Owner = owner;
        Balance = 0M;
    }

    public virtual void Deposit(decimal amount)
    {
        Balance += amount;
    }

    public virtual void Withdraw(decimal amount)
    {
        Balance -= amount;
    }
}

public class SavingsAccount : Account
{
    public decimal InterestRate { get; }

    public SavingsAccount(string accountNumber, string owner, decimal interestRate)
        : base(accountNumber, owner)
    {
        InterestRate = interestRate;
    }
}

public class CheckingAccount : Account
{
    public decimal OverdraftLimit { get; }

    public CheckingAccount(string accountNumber, string owner, decimal overdraftLimit)
        : base(accountNumber, owner)
    {
        OverdraftLimit = overdraftLimit;
    }
}