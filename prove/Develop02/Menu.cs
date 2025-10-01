public class Menu
{
    public void openMenu()
    {
        Console.WriteLine("1. Write New Entry\n2. Display Journal\n3. Save Journal\n4. Load Journal\n(Select 1-4, or 0 to exit)");
    }

    public string selectOption()
    {
        return Console.ReadLine();
    }
}