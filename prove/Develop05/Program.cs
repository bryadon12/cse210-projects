using System;
using System.Runtime.InteropServices.Marshalling;

class Program
{
    static void Main(string[] args)
    {
        GoalList goals = new GoalList();
        int points = 0;

        Menu mainMenu = new Menu(new List<String> { "Create Goal", "View Goals", "Complete Goal", "View Points", "Quit" });
        Menu goalMenu = new Menu(new List<string> { "Simple Goal", "Check-List Goal", "Eternal Goal" });
        int choice;
        do
        {
            choice = mainMenu.OpenMenu();
            if (choice == 1)
            {
                choice = goalMenu.OpenMenu();

                if (choice == 1)
                {
                    goals.AddGoal(new SimpleGoal());
                }
                else if (choice == 2)
                {
                    goals.AddGoal(new ChecklistGoal());
                }
                else if (choice == 3)
                {
                    goals.AddGoal(new EternalGoal());
                }
            }
            else if (choice == 2)
            {
                goals.ListGoals();
            }
            else if (choice == 3)
            {

            }
            else if (choice == 4)
            {

            }
        } while (choice != 4);
    }
}