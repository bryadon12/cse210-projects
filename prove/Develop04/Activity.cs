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
        Console.WriteLine($"Welcom to the {_activityName} activity.\n\n {_description}\nHow long, in seconds, would you like do this activity? ");
        _time = int.Parse(Console.ReadLine());
        Console.WriteLine("Prepare to Begin.");
        Delay(2);
    }

    public void EndingMessage()
    {
        Console.WriteLine("Great Job!!!");
        Delay(3);
        Console.WriteLine($"You have completed the {_activityName} activity for {_time} seconds.");
    }

    public void Delay(int time)
    {
        DateTime endtime = Timer(time);
        while (DateTime.Now < endtime)
        {
            foreach (String position in _spinner)
            {
                Console.Write(position);
                Thread.Sleep(500);
                Console.Write("\b \b");
            }
        }
    }
    
    public DateTime Timer()
    {
        return Timer(_time);
    }

    public DateTime Timer(int time)
    {
        DateTime currentTime = DateTime.Now;
        return currentTime.AddSeconds(time);
    }
    
    public void CountDown(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b\b \b{i} ");
        }
    }
}