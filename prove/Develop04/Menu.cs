public class Menu
{
    private List<string> _options;

    public Menu(List<string> options)
    {
        _options = options;
    }
    public void OpenMenu()
    {
        int i = 1;
        foreach (string option in _options)
        {
            Console.WriteLine($"{i}. {option}");
            i++; 
        }   
        SelectOption();
    }

    public int SelectOption()
    {
        return int.Parse(Console.ReadLine());
    }

}