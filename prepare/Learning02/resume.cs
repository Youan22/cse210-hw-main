using System;
using System.Linq;

public class Resume
{
   public string _name;

    //  initialize list to a new List before using it.
    public List<Job> _jobs = new List<Job>();

    public void Display()
    {
        Console.WriteLine($"Name: {_name}");
        Console.WriteLine("Jobs:");

        // using linq method to iterate over the list
        _jobs.ForEach(job => job.Display());
    }
}
