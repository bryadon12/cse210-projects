using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public string _filename = "journal.txt";
    public int _promptNumber = 0;

    public void addEntry(Entry entry)
    {
        _journal.Add(entry);
        _promptNumber++;
        if (_promptNumber == 5)
        {
            _promptNumber = 0;
        }
    }

    public List<Entry> getJournal()
    {
        return _journal;
    }

    public string getPrompt()
    {
        string[] prompts = ["Who was the most interesting person I interacted with today?",
            "What was the best part of my day?", "How did I see the hand of the Lord in my life today?",
            "What was the strongest emotion I felt today?", "If I had one thing I could do over today, what would it be?"];
        string prompt = prompts[_promptNumber];
        return prompt;
    }
}