public class Activity
{
    private string _activityName;
    private string _description;
    private int _time;

    public Activity(string activityName, string description)
    {
        _activityName = activityName;
        _description = description;
        StartingMessage();

    }

    public void StartingMessage()
    {
        Console.WriteLine($"{_activityName}: {_description}\nHow long would you like do this activity? ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to Begin.");
        Thread.Sleep(5000);
        Console.WriteLine("I waited 5 seconds to print this.");
    }

    public void EndingMessage()
    {
        Console.WriteLine("Great Job!!!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed {_activityName} for {_time} seconds.");
    }
}