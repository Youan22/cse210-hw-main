using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new bank manager
        var accounts = new List<Account>();
        var bankManager = new BankManager(accounts);

        // Create a savings account and a checking account
        var savingsAccount = new SavingsAccount("SAV-001", "John Doe", 1.5M);
        var checkingAccount = new CheckingAccount("CHK-001", "John Doe", 1000M);

        // Make some transactions on the accounts
        savingsAccount.Deposit(1000M);
        checkingAccount.Deposit(500M);
        checkingAccount.Withdraw(200M);

        // Add the accounts to the bank manager's account list
        accounts.Add(savingsAccount);
        accounts.Add(checkingAccount);

        // Create a loan application and a credit card application
        var loanApplication = new LoanApplication("John Doe", 10000M, 24);
        var creditCardApplication = new CreditCardApplication("John Doe", 5000M);

        // Add the applications to the bank manager's pending application lists
        bankManager.PendingLoanApplications.Add(loanApplication);
        bankManager.PendingCreditCardApplications.Add(creditCardApplication);

        // Process the pending loan and credit card applications
        bankManager.ProcessPendingApplications();

        // Print the current state of the accounts
        Console.WriteLine("Current state of accounts:");
        foreach (var account in accounts)
        {
            Console.WriteLine($"Account number: {account.AccountNumber}, Owner: {account.Owner}, Balance: {account.Balance:C}");
        }

        Console.ReadLine();
    }

    private class CheckingAccount
    {
        private string v1;
        private string v2;
        private decimal v3;

        public CheckingAccount(string v1, string v2, decimal v3)
        {
            this.v1 = v1;
            this.v2 = v2;
            this.v3 = v3;
        }

        internal void Deposit(decimal v)
        {
            throw new NotImplementedException();
        }

        internal void Withdraw(decimal v)
        {
            throw new NotImplementedException();
        }
    }
}
