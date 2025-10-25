public class Comment
{
    private string _name;
    private string _text;

    public Comment(string name, string text)
    {
        _name = name;
        _text = text;
    }

    public Comment()
    {
        Console.WriteLine("Who wrote this comment? ")
        _name = Console.ReadLine();
        Console.WriteLine("What did they write? ")
        _text = Console.ReadLine();
    }

    public void SetName(string name)
    {
        _name = name;
    }

    public string GetName()
    {
        return _name;
    }

    public void SetText(string text)
    {
        _text = text;
    }

    public string GetText()
    {
        return _text;
    }

    public void DisplayComment()
    {
        Console.WriteLing($"\n{_name}: {_text}");
    }
}