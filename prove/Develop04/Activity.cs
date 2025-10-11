public class Activity
{
    private string _activityName;
    private string _description;
    private int _time;
    private List<string> _spinner;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        _spinner = new List<string> { "/", "-", "\\", "|" };
        StartingMessage();

    }

    public void StartingMessage()
    {
        Console.WriteLine($"{_activityName}: {_description}\nHow long would you like do this activity? ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to Begin.");
        Delay(5);
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
}