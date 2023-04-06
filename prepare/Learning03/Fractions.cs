public class Fraction
{
    private int numerator;
    private int denominator;

    // Default constructor that initializes the fraction to 1/1
    public Fraction()
    {
        numerator = 1;
        denominator = 1;
    }

    // Constructor that initializes the fraction to a whole number
    public Fraction(int wholeNumber)
    {
        numerator = wholeNumber;
        denominator = 1;
    }

    // Constructor that initializes the fraction to a numerator and denominator
    public Fraction(int num, int denom)
    {
        numerator = num;
        if (denom == 0) // Check for invalid denominator
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = denom;
    }

    // Getter for the numerator
    public int GetNumerator()
    {
        return numerator;
    }

    // Setter for the numerator
    public void SetNumerator(int num)
    {
        numerator = num;
    }

    // Getter for the denominator
    public int GetDenominator()
    {
        return denominator;
    }

    // Setter for the denominator
    public void SetDenominator(int denom)
    {
        if (denom == 0) // Check for invalid denominator
        {
            throw new ArgumentException("Denominator cannot be zero.");
        }
        denominator = denom;
    }

    // Method that returns the fraction as a string in the form "numerator/denominator"
    public string GetFractionString()
    {
        return $"{numerator}/{denominator}";
    }

    // Method that returns the decimal value of the fraction
    public double GetDecimalValue()
    {
        return (double)numerator / (double)denominator;
    }
}
