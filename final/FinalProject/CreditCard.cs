 using System;
 // Credit card class
    
    public class CreditCard
    {
        public string CardNumber { get; }
        public string Owner { get; }
        public decimal CreditLimit { get; }
        public decimal Balance { get; private set; }

        public CreditCard(string cardNumber, string owner, decimal creditLimit)
        {
            CardNumber = cardNumber;
            Owner = owner;
            CreditLimit = creditLimit;
            Balance = 0.0M;
        }

        public bool Charge(decimal amount)
        {
            if (amount <= CreditLimit - Balance)
            {
                Balance += amount;
                return true;
            }
            return false;
        }

        public void MakePayment(decimal amount)
        {
            Balance -= amount;
        }
    }