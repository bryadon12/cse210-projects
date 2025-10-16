public class ChecklistGoal : Goal
{
    private int _bonusPoints;
    private int _remainingEvents;

    public ChecklistGoal(string name, int points, int bonusPoints, int remainingEvents) : base(name, points)
    {
        _remainingEvents = remainingEvents;
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
}