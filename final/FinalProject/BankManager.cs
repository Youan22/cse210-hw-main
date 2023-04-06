using System;
public class BankManager
{
    public List<BankApp.Account> Accounts { get; }
    public List<LoanApplication> PendingLoanApplications { get; }
    public List<CreditCardApplication> PendingCreditCardApplications { get; }
    public List<NewSavingsAccount> Accounts1 { get; }

    public BankManager(List<BankApp.Account> accounts)
    {
        Accounts = accounts;
        PendingLoanApplications = new List<LoanApplication>();
        PendingCreditCardApplications = new List<CreditCardApplication>();
    }

    // public BankManager(List<NewSavingsAccount> accounts)
    // {
    // }

    public BankManager(List<NewSavingsAccount> accounts)
    {
        Accounts1 = accounts;
    }

    public void ProcessLoanApplication(LoanApplication application)
    {
        // TODO: Verify applicant's credit history and income, and approve or reject the application
    }

    public void ProcessCreditCardApplication(CreditCardApplication application)
    {
        // TODO: Verify applicant's credit history and approve or reject the application
    }

    internal void ProcessPendingApplications()
    {
        throw new NotImplementedException();
    }
}
