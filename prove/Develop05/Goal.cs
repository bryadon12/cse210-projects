public class Goal
{
    private int _points;
    private string _name;

    public Goal(int points, string name)
    {
        _points = points;
        _name = name;
    }

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
}