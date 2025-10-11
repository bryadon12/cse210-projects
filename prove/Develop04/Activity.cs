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
        Console.WriteLine($"Welcom to the {_activityName} activity.\n\n {_description}\n\nHow long, in seconds, would you like do this activity? ");
        _time = 5;  //int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to Begin.");
        Delay(3);
    }

    public void EndingMessage()
    {
        Console.WriteLine("Great Job!!!");
        Thread.Sleep(3000);
        Console.WriteLine($"You have completed {_activityName} for {_time} seconds.");
    }

    public void Delay(int time)
    {
        while ()
            foreach (String position in _spinner)
            {
                Console.Write(position);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
    }
    
    public DateTime Timer()
    {
        DateTime currentTime = DateTime.Now;
        return currentTime.AddSeconds(_time);
    }
}