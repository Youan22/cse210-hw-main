using System;
using System.Collections.Generic;

    class Program
    {
        static void Main(string[] args)
        {
            Menu menu = new Menu();
            while (true)

        {
            menu.Display();

            // Run();
            Console.Write("Enter your choice (1-4): ");
            string choice = Console.ReadLine();
            System.Console.WriteLine();

            switch (choice)
            {
                case "1":
                    BreathingActivity breathingActivity = new BreathingActivity();
                    breathingActivity.Start();
                    Console.Clear();
                    Console.Clear();
                    break;
                case "2":
                    ReflectionActivity reflectionActivity = new ReflectionActivity();
                    reflectionActivity.Start();
                    Console.Clear();
                    break;
                case "3":
                    Console.Clear();
                    ListingActivity listingActivity = new ListingActivity();
                    listingActivity.Start();
                    break;
                case "4":
                    Console.WriteLine("Goodbye!");
                    System.Console.WriteLine("We hope you will come back soon!!");
                    return;
                default:
                    Console.WriteLine("Invalid choice, please try again.");
                    break;
            }
    //     }
        }
        }
    }




