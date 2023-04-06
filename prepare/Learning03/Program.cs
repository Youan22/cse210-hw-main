using System;

class Program
{
static void Main(string[] args)
{
// Create a new instance of Fraction using the first constructor
Fraction f1 = new Fraction();
Console.WriteLine($"Fraction 1: {f1.GetFractionString()}"); // Output the fraction as a string
Console.WriteLine($"Decimal value: {f1.GetDecimalValue()}"); // Output the decimal value
    // Create a new instance of Fraction using the second constructor
    Fraction f2 = new Fraction(5);
    Console.WriteLine($"Fraction 2: {f2.GetFractionString()}"); // Output the fraction as a string
    Console.WriteLine($"Decimal value: {f2.GetDecimalValue()}"); // Output the decimal value

    // Create a new instance of Fraction using the third constructor
    Fraction f3 = new Fraction(3, 4);
    Console.WriteLine($"Fraction 3: {f3.GetFractionString()}"); // Output the fraction as a string
    Console.WriteLine($"Decimal value: {f3.GetDecimalValue()}"); // Output the decimal value

    // Create a new instance of Fraction using the third constructor
    Fraction f4 = new Fraction(1, 3);
    Console.WriteLine($"Fraction 4: {f4.GetFractionString()}"); // Output the fraction as a string
    Console.WriteLine($"Decimal value: {f4.GetDecimalValue()}"); // Output the decimal value
}
}