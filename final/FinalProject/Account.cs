using System;

namespace BankApp

    // Base class for bank accounts
    public class Account
    {
        public string AccountNumber { get; }
        public decimal Balance { get; protected set; }
        public string Owner { get; }

        public Account(string accountNumber, string owner)
        {
            AccountNumber = accountNumber;
            Owner = owner;
            Balance = 0.0M;
        }

        public virtual void Deposit(decimal amount)
        {
            Balance += amount;
        }

        public virtual bool Withdraw(decimal amount)
        {
            if (amount <= Balance)
            {
                Balance -= amount;
                return true;
            }
            return false;
        }
    