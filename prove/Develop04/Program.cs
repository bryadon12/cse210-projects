using System;
using System.Net;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu(new List<String> {"Breathing", "Reflection", "Listening", "Quit"});

        int choice = activityMenu.OpenMenu();
        Console.Clear();
        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity();
            activity.DoActivity();
        }
        else if (choice == 2)
        {
            ReflectionActivity activity = new ReflectionActivity();
            activity.DoActivity();

        }
        else if (choice == 3)
        {
            ListeningActivity activity = new ListeningActivity();
            activity.DoActivity();

        }
    }
}