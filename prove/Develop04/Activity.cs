public class Activity
{
    private int duration;
    private string Description;
    private string _name; 

    protected DateTime _futureTime;

    
    public Activity(string Des, string name)
    {
        _name = name;
        Description = Des;
        duration = 60;

    }
    
    public virtual void StartMessage()
    {
        Console.WriteLine($"Welcome to the { _name}, activity! ");
        System.Console.WriteLine();
        System.Console.WriteLine(Description);
        System.Console.WriteLine();
    
    }
    public void EndingMessage()

    {
        Thread.Sleep(10);
        System.Console.WriteLine("Good Job!");
        display_pause();
        System.Console.WriteLine($"You have completed anonther {duration} seconds of {_name} Activity.");
        Thread.Sleep(5000);
    }
    
    public virtual int GetTime(int second)
    {
        System.Console.Write("How long in seconds would you like your session? ");
        string time = Console.ReadLine();
        second = int.Parse(time);
        duration = second;
        display_pause();
        Console.Clear();
        return duration; 
    }
    public bool  CalculateTime()
    {
        DateTime currentTime = DateTime.Now;
        DateTime _futureTime = currentTime.AddSeconds(duration);
        if (currentTime < _futureTime)
        {
            return false;
        }
        else 
        {
            return true;
        }
    }

    public void SetTime(DateTime futuretime)
    {
        _futureTime = futuretime;
    }
    public void display_pause()
    {
        Console.Write("Pausing ");
        for (int i = 0; i < 3; i++)
        {
            Console.Write(".");
            System.Threading.Thread.Sleep(500);
        }
        Console.WriteLine();
    }
    
    public virtual void end()
    {
        Console.WriteLine("Ending activity...");
        display_pause();
    }
}