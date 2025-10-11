public class Activity
{
    private string _activityName;
    private string _description;
    private int _time;
    private List<string> _spinner;

    public Activity()
    {
        _spinner = new List<string> { "/", "-", "\\", "|" };
        StartingMessage();

    }

    public void SetActivity(string activityName)
    {
        _activityName = activityName;
    }

        public void SetDescription(string description)
    {
        _description = description;
    }

    public void StartingMessage()
    {
        Console.WriteLine($"{_activityName}: {_description}\nHow long (in seconds) would you like do this activity? ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to Begin.");
        Delay(4);
    }

    public void EndingMessage()
    {
        Console.WriteLine("Great Job!!!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed {_activityName} for {_time} seconds.");
    }

    public void Delay(int time)
    {
        foreach (String position in _spinner)
        {
            Console.Write(position);
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }

    public int GetTime()
    {
        return _time;
    }
}