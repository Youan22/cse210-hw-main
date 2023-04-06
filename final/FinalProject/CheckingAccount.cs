// Checking account class
using BankApp;

// public class CheckingAccount : Account
//     {
//         public decimal OverdraftLimit { get; }

//         public CheckingAccount(string accountNumber, string owner, decimal overdraftLimit) : base(accountNumber, owner)
//         {
//             OverdraftLimit = overdraftLimit;
//         }

//         public override bool Withdraw(decimal amount)
//         {
//             if (amount <= Balance + OverdraftLimit)
//             {
//                 Balance -= amount;
//                 return true;
//             }
//             return false;
//         }
//     }

public class CheckingAccount : Account
{
    public CheckingAccount(string accountNumber, string owner, decimal balance) : base(accountNumber, owner, balance)
    {
    }

    public override void Withdraw(decimal amount)
    {
        if (Balance - amount < -1000M)
        {
            throw new InvalidOperationException("Insufficient funds for withdrawal");
        }

        Balance -= amount;
    }
}