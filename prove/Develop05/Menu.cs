public class Menu
{
    private List<string> _options;

    public Menu(List<string> options)
    {
        _options = options;
    }
    public int OpenMenu()
    {
        int i = 1;
        foreach (string option in _options)
        {
            Console.WriteLine($"{i}. {option}");
            i++;
        }
        Console.WriteLine("Please select a choice from the menu: ");
        return SelectOption();
    }

    public int SelectOption()
    {
        return int.Parse(Console.ReadLine());
    }
}