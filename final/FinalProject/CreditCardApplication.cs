public class CreditCardApplication
{
    public string ApplicantName { get; }
    public decimal CreditLimit { get; }

    public CreditCardApplication(string applicantName, decimal creditLimit)
    {
        ApplicantName = applicantName;
        CreditLimit = creditLimit;
    }
}