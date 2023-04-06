using System;
using System.Collections.Generic;

public class ListingActivity : Activity
{
    private List<string> prompts = new List<string>()
    {
        // String used to ask question the users and help them think about things to list,
        "Who are people that you appreciate?",
        "What are some things that make you happy?",
        "What are some things that you are grateful for?",
        "What are some things that you want to accomplish?",
        "What are some things that you are proud of?",
        "Do you have any regrets and what will you differently?",
    };
    public ListingActivity() : base("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.", "Listing")
    {

    }
    public override void StartMessage()
    {
        base.StartMessage();
    }
     public override int GetTime(int second)
    {
        return base.GetTime(second);
    }
    public void Start()
    {
        StartMessage();
        int getTime = GetTime(25);
        Console.Clear();

        DateTime startTime = new DateTime();
        DateTime futureTime = startTime.AddSeconds(getTime);
        Console.WriteLine("Please respond to the following prompts:");
        while(startTime < futureTime)
        { 
            startTime = DateTime.Now;
        foreach (string prompt in prompts)
        {
            Console.WriteLine(prompt + " ");
            string response = Console.ReadLine();
            Console.WriteLine("You entered: " + response);
        }
        }
        EndingMessage();
        // Console.WriteLine("Thank you for participating in the Listing Activity!");
    }
}
