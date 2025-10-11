using System;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu(new List<String> {"Breathing", "Reflection", "Listening"});

        int choice = 1; //activityMenu.OpenMenu();

        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity();
            Console.Clear();
            activity.DoActivity();
        }
        else if (choice == 2)
        {
            ReflectionActivity activity = new ReflectionActivity();

        }
        else
        {
            ListeningActivity activity = new ListeningActivity();

        }
        
        
    }
}