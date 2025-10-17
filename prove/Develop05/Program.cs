using System;
using System.Runtime.InteropServices.Marshalling;
using System.Transactions;

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
                Console.WriteLine("Press Enter to return to the Menu.");
                Console.ReadLine();
            }
            else if (choice == 3)
            {
                goals.ListGoals();
                Console.WriteLine("Enter the number of the goal you have completed.");
                points += goals.CompleteGoal(int.Parse(Console.ReadLine()));
            }
            else if (choice == 4)
            {
                Console.WriteLine($"You currently have {points} points ");
                Console.WriteLine("Press Enter to return to the Menu.");
                Console.ReadLine();
            }
            else
            {
                choice = 5;
            }
        } while (choice != 5);
    }
}