using System.ComponentModel.DataAnnotations.Schema;

public class SimpleGoal : Goal
{
    private bool _complete;

    public SimpleGoal() : base()
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

    public override string GetStatus()
    {
        if (_complete)
        {
            return "[X]";
        }
        else
        {
            return "[ ]";
        }
    }
}