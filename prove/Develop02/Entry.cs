using System.Net;

public class Entry
{
    public string _date;
    public string _response;
    public Prompt _prompt;

    public string getEntry()
    {
        return $"{_prompt}: {_response}({_date})";
    }
}