using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
            // Menu goalMenu = new Menu(new List<String> {"Simple Goal", "Checklist Goal", "Eternal Goal", "List Goals", "See Points", "Quit"});

            // int choice = goalMenu.OpenMenu();
            // if (choice == 1)
            // {
            //     SimpleGoal goal = new SimpleGoal();
            // }
            // else if (choice == 2)
            // {


            // }
            // else if (choice == 3)
            // {


            // }

        List<Goal> goals = new List<Goal>();
        SimpleGoal goal = new SimpleGoal();
        goals.Add(goal);

        foreach (Goal item in goals)
        {
            Console.WriteLine();
        }

    }
}