public class GoalList
{
    List<Goal> _goals;

    public GoalList()
    {
        _goals = new List<Goal>();
    }

    public void AddGoal(Goal goal)
    {
        _goals.Add(goal);
    }

    public void ListGoals()
    {
        int i = 1;
        foreach (Goal item in _goals)
        {
            Console.WriteLine($"{i}. {item.GetName()} {item.GetStatus()}");
            i++;
        }
    }

    public int CompleteGoal(int goalNumber)
    {
        return _goals[goalNumber-1].DoGoal();
    }
}