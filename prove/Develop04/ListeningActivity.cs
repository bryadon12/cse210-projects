public class ListeningActivity : Activity
{
    private List<string> _prompts;
    private List<string> _remainingPrompts;
    private Random _generator;
    public ListeningActivity() : base ()
    {
        _prompts = new List<string> {"Who are people that you appreciate?",
                                    "What are personal strengths of yours?",
                                    "Who are people that you have helped this week?",
                                    "When have you felt the Holy Ghost this month?",
                                    "Who are some of your personal heroes?"};

        _remainingPrompts = _prompts;

        _generator = new Random();
        SetActivity("Listening");
        SetDescription("This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area.");
        Delay(5);
    }

    public string GetPrompt()
    {
        if (_remainingPrompts.Count == 0)
        {
            _remainingPrompts = _prompts;
        }
        int i = _generator.Next(_remainingPrompts.Count);
        string item = _remainingPrompts[i];
        _remainingPrompts.RemoveAt(i);
        return item;
    }



    public void DoActivity()
    {
        int i = 0;
        DateTime endtime = Timer();
        Console.Clear();
        Console.WriteLine("Get Ready...");
        Delay(3);
        Console.WriteLine("List as many responses as you can to the following prompt: ");
        Console.WriteLine($"--- {GetPrompt()} ---");
        Console.Write("You may begin in :   ");
        CountDown(6);
        Console.WriteLine("\b");

        while (DateTime.Now < endtime)
        {
            Console.ReadLine();
            i++;
        }
        Console.WriteLine($"You listed {i} items!!!");
        EndingMessage();
    }
}