using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public string _filename = "journal.txt";
    public string _promptFile = "prompts.txt";

    public string[] _prompts;

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

    public void readJournal()
    {

    }

    public List<Entry> getJournal()
    {
        return _journal;
    }

    public string getPrompt()
    {
        
        if (_prompts.Length == 0)
        {
            readPrompts();
        }
        string prompt = _prompts[_promptNumber];
        return prompt;
    }
        public void readPrompts()
    {
        _prompts = System.IO.File.ReadAllLines(_promptFile);
    }

}