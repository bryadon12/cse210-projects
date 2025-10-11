public class BreathingActivity : Activity
{
    public BreathingActivity() : base()
    {
        SetActivity("Breathing");
        SetDescription("This activity will help you relax by walking your through breathing in and out slowly. Clear your mind and focus on your breathing.");
        Delay(5);
    }

    public void BreathCount(int time)
    {
        for (int i = time; i >= 0; i--)
        {
            Thread.Sleep(1000);
            Console.Write($"\b \b{i}");
        }
    }

    public void Breath()
    {
        Console.Write("Breathe in:  ");
        BreathCount(4);
        Console.WriteLine("\n");
        Console.Write("Breathe out:  ");
        BreathCount(6);
        Console.WriteLine("\n");
    }
    
    public void DoActivity()
    {
        DateTime currentTime = DateTime.Now;
        DateTime endTime = currentTime.AddSeconds(GetTime());

        while (DateTime.Now < endTime)
        {
            Breath();
        }
        EndingMessage();
    }
}