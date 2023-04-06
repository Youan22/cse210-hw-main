using BankApp;

internal class SavingsAccount
{
    private string v1;
    private string v2;
    private decimal v3;

    public SavingsAccount(string v1, string v2, decimal v3)
    {
        this.v1 = v1;
        this.v2 = v2;
        this.v3 = v3;
    }
}// Savings account class
    public class SavingsAccount : Account
    {
        public decimal InterestRate { get; }

        public SavingsAccount(string accountNumber, string owner, decimal interestRate) : base(accountNumber, owner)
        {
            InterestRate = interestRate;
        }

        public void ApplyInterest()
        {
            Balance += Balance * (InterestRate / 100.0M);
        }
    }

