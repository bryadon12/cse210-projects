public abstract class Goal
{
    private int _points;
    private string _name;

    public Goal()
    {
        Console.WriteLine("What would you like to call this goal?");
        _name = Console.ReadLine();
        Console.WriteLine("How many points is this goal worth? (Enter a positive whole number)");
        _points = int.Parse(Console.ReadLine());

    }
    // public Goal(string name, int points)
    // {
    //     _points = points;
    //     _name = name;
    // }

    public int GetPoints()
    {
        return _points;
    }

    public void SetPoints(int points)
    {
        _points = points;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public abstract int DoGoal();
    public virtual string GetStatus()
    {
        return "";
    }
}

