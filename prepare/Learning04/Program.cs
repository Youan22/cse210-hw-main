using System;

class Program
{
    static void Main(string[] args)
    {
        Assignment assignment = new Assignment("Samuel Bennett", "Multiplication");
        string summary = assignment.GetSummary();

        Console.WriteLine(summary);

        {
        MathAssignment mathAssignment = new MathAssignment("Roberto Rodriguez", "Fractions", "02/28/2023", "Section 7.3 Problems 8-19");

        // Test the GetSummary method
        Console.WriteLine(mathAssignment.GetSummary());

        // Test the GetHomeworkList method
        Console.WriteLine(mathAssignment.GetHomeworkList());
    }

        

        WritingAssignment writingAssignment = new WritingAssignment("Mary Waters", "European History", "The Causes of World War II");
        Console.WriteLine($"{writingAssignment.GetSummary()}\n{writingAssignment.GetWritingInformation()}");



    }
}
