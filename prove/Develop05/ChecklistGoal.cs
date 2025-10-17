public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _remainingEvents;
    private int _totalEvents;

    public ChecklistGoal() : base()
    {
        Console.WriteLine("Enter how many steps until you have completed your goal: ");
        _totalEvents = _remainingEvents = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter how many bonus points for finishing your goal: ");
        _bonusPoints = int.Parse(Console.ReadLine());
    }

    public override int DoGoal()
    {
        if (_remainingEvents == 1)
        {
            _remainingEvents--;
            return GetPoints() + _bonusPoints;
        }
        else if (_remainingEvents > 1)
        {
            _remainingEvents--;
            return GetPoints();
        }
        else
        {
            Console.WriteLine("This Goal is already Completed");
            return 0;
        }
    }

    public override string GetStatus()
    {
        return $"{_totalEvents-_remainingEvents}/{_totalEvents} Completed";
    }
}