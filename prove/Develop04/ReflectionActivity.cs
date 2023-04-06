public class ReflectionActivity : Activity

{
    public List<string> prompts;
    public List<string> questions;


    
    public ReflectionActivity() : base("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.", "Reflection")

    {
        prompts = new List<string>{"What are you grateful for today?", "What did you learn today?", "What can you do better tomorrow?"};
        questions = new List<string>{"Why did you choose that answer?", "How can you apply what you learned?", "What steps will you take to improve?"};
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
            string prompt = get_random_prompt();
            Console.WriteLine("Prompt: {0}", prompt);
            startTime = DateTime.Now;
            for (int i = 0; i < 3; i++)
        {
            string question = get_random_question();
            Console.WriteLine("Question {0}: {1}", i+1, question);
            System.Threading.Thread.Sleep(5000);
        }
        }
        EndingMessage();
        
    }
    
    public string get_random_prompt()
    {
        Random rand = new Random();
        return prompts[rand.Next(prompts.Count)];
    }
    
    public string get_random_question()
    {
        Random rand = new Random();
        return questions[rand.Next(questions.Count)];
    }
}