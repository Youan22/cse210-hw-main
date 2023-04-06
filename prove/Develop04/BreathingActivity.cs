public class BreathingActivity : Activity
{
    public BreathingActivity(): base( "This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.", "Breathing")
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
        while(startTime < futureTime)
        {   
        
            // System.Console.WriteLine(startTime);
            // System.Console.WriteLine(futureTime);
            startTime = DateTime.Now;
           Console.WriteLine("Breathe in...");
            display_countdown(5);
            startTime = DateTime.Now;
            Console.WriteLine("Breathe out...");
            display_countdown(5); 
        }
        EndingMessage();
    }
    
    public void display_countdown(int seconds)
    {
        for (int i = seconds; i >= 1; i--)
        {
            Console.Write("{0}... ", i);
            System.Threading.Thread.Sleep(1000);
        }
        Console.WriteLine();
    }
}