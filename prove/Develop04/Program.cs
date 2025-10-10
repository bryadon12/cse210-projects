using System;

class Program
{
    static void Main(string[] args)
    {
        Menu activityMenu = new Menu(new List<String> {"Breathing", "Reflection", "Listening"});

        int choice = activityMenu.OpenMenu();

        if (choice == 1)
        {
            BreathingActivity activity = new BreathingActivity("breathing", "in and out");
            activity.EndingMessage();
        }
        else if (choice == 2)
        {
            ReflectionActivity activity = new ReflectionActivity("reflection", "think about stuff");
            activity.EndingMessage();
        }
        else
        {
            ListeningActivity activity = new ListeningActivity("listening", "be quite");
            activity.EndingMessage();
        }
        


    }
}