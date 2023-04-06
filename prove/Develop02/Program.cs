using System.Collections.Generic;
using System.IO;


    public class Program
    {
        static void Main(string[] args)
        {
            Journal myJournal = new Journal();
            bool exit = false;
            while (!exit)
            {
                Console.Clear();
                Console.WriteLine("Welcome to the Journal Program!");
                Console.WriteLine("Please select an option:");
                Console.WriteLine("1. Write a new entry");
                Console.WriteLine("2. Display the journal");
                Console.WriteLine("3. Save the journal to a file");
                Console.WriteLine("4. Load the journal from a file");
                Console.WriteLine("5. Exit");
                string input = Console.ReadLine();
                switch (input)
                {
                    case "1":
                        myJournal.WriteNewEntry();
                        break;
                    case "2":
                        myJournal.DisplayJournal();
                        break;
                    case "3":
                        myJournal.SaveJournal();
                        break;
                    case "4":
                        myJournal.LoadJournal();
                        break;
                    case "5":
                        exit = true;
                        break;
                    default:
                        Console.WriteLine("Invalid input. Please try again.");
                        break;
                }
                Console.WriteLine("Press any key to continue...");
                Console.ReadKey();
            }
        }
    }
