public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _remainingEvents;
    private int _totalEvents;

    public ChecklistGoal() : base()
    {
        
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