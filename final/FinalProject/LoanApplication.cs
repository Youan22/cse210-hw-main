public class LoanApplication
{
    public string ApplicantName { get; }
    public decimal Amount { get; }
    public int TermInMonths { get; }

    public LoanApplication(string applicantName, decimal amount, int termInMonths)
    {
        ApplicantName = applicantName;
        Amount = amount;
        TermInMonths = termInMonths;
    }
}