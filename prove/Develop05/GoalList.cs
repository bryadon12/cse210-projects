public class GoalList
{
    List<Goal> _goals;

    public void ListGoals()
    {
        int i = 1;
        foreach (Goal item in _goals)
        {
            Console.WriteLine($"{i}. {item.GetName()}");
        }
    }
}