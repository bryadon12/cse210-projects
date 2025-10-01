
public class Entry
{
    public string _date;
    public string _response;
    public string _prompt;

    public Entry(string date, string response, string prompt)
    {
        _date = date;
        _response = response;
        _prompt = prompt;
    }
    public string getEntry()
    {
        return $"{_prompt}: {_response}({_date})";
    }
}