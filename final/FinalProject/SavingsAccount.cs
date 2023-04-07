using BankApp;

internal class SavingsAccount
{
    private string accountNumber;
    private string owner;
    private decimal interestRate;

   public SavingsAccount(string accountNumber, string owner, decimal interestRate) : base(accountNumber, owner, interestRate)
    {
        this.accountNumber = accountNumber;  
        this.owner = owner;
        this.interestRate = interestRate;
    }
//  internal void
    internal void Deposit(decimal v)
    {
        throw new NotImplementedException();
    }
}// Savings account class
    public class NewSavingsAccount : Account
    {
        public decimal InterestRate { get; }

   public NewSavingsAccount(string accountNumber, string owner, decimal interestRate) : base(accountNumber, owner, 0)
{
    InterestRate = interestRate;
}

        public void ApplyInterest()
        {
            Balance += Balance * (InterestRate / 100.0M);
        }
    }

