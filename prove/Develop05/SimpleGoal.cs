using System.ComponentModel.DataAnnotations.Schema;

public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal(string name, int points) : base(name, points)
    {
        _complete = false;
    }

    public override int DoGoal()
    {
        if (!_complete)
        {
            _complete = true;
            return GetPoints();
        }
        else
        {
            Console.WriteLine("This Goal is already Completed");
            return 0;
        }
    }
}