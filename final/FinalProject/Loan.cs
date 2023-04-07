 using System;

// Loan class
    public class Loan
    {
        public string LoanNumber { get; }
        public string Owner { get; }
        public decimal Balance { get; private set; }
        public decimal InterestRate { get; }
        public int TermInMonths { get; }

        public Loan(string loanNumber, string owner, decimal amount, decimal interestRate, int termInMonths)
        {
            LoanNumber = loanNumber;
            Owner = owner;
            Balance = amount;
            InterestRate = interestRate;
            TermInMonths = termInMonths;
        }

        public decimal CalculateMonthlyPayment()
        {
            decimal monthlyInterestRate = InterestRate / 12.0M;
            decimal numerator = Balance * monthlyInterestRate;
            decimal denominator = 1 - (decimal)Math.Pow((double)(1 + monthlyInterestRate), -TermInMonths);
            return numerator / denominator;
        }

        public void MakePayment(decimal amount)
        {
            Balance -= amount;
        }
    } 