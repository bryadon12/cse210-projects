using System.Net;

public class Entry
{
    public string _date;
    public string _response;
    public Prompt _prompt;

    public void printEntry(string _date, string _response, Prompt _prompt)
    {
        Console.WriteLine($"{_prompt}: {_response}({_date})");
    }
}