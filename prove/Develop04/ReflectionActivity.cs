public class ReflectionActivity : Activity
{
    private List<string> _prompts;
    private List<string> _remainingPrompts;
    private List<string> _questions;
    private List<string> _remainingQuestions;
    private Random _generator ;
    public ReflectionActivity() : base()
    {
        _prompts = new List<string> {"Think of a time when you stood up for someone else.",
                                    "Think of a time when you did something really difficult.",
                                    "Think of a time when you helped someone in need.",
                                    "Think of a time when you did something truly selfless."};
        _questions = new List<string> {"Why was this experience meaningful to you?",
                                        "Have you ever done anything like this before?",
                                        "How did you get started?",
                                        "How did you feel when it was complete?",
                                        "What made this time different than other times when you were not as successful?",
                                        "What is your favorite thing about this experience?",
                                        "What could you learn from this experience that applies to other situations?",
                                        "What did you learn about yourself through this experience?",
                                        "How can you keep this experience in mind in the future?"};
        _remainingPrompts = _prompts;
        _remainingQuestions = _questions;
        _generator = new Random();
        SetActivity("Reflecting");
        SetDescription("This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life.");
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

    public string GetQuestion()
    {
        if (_remainingQuestions.Count == 0)
        {
            _remainingQuestions = _prompts;
        }
        int i = _generator.Next(_remainingQuestions.Count);
        string item = _remainingQuestions[i];
        _remainingQuestions.RemoveAt(i);
        return item;
    }

    public void DoActivity()
    {
        DateTime endtime = Timer();
        Console.WriteLine(GetPrompt());
        Console.WriteLine("\n Press enter when you have thought of an answer.");
        Console.ReadLine();
        while (DateTime.Now < endtime)
        {
            Console.WriteLine(GetQuestion());
            Delay(12);
        }
        EndingMessage();
    }
}