using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        List<double> numbers = new List<double>();
        double input;

        Console.WriteLine("Enter a list of numbers, type 0 when finished.");

        while (true)
        {
            Console.Write("Enter number: ");
            input = Convert.ToDouble(Console.ReadLine());

            if (input == 0)
            {
                break;
            }
            else
            {
                numbers.Add(input);
            }
        }

        // Sum of numbers in the list
        double sum = numbers.Sum();
        Console.WriteLine("The sum is: " + sum);

        // Average of numbers in the list
        double average = sum / numbers.Count();
        Console.WriteLine("The average is: " + average);

        // Largest number in the list
        double max = numbers.Max();
        Console.WriteLine("The largest number is: " + max);

        // Smallest positive number
        double minPositive = numbers.Where(x => x > 0).Min();
        Console.WriteLine("The smallest positive number is: " + minPositive);

        // Sort the list
        numbers.Sort();
        Console.WriteLine("The sorted list is:");
        numbers.ForEach(x => Console.WriteLine(x));
    }
}
