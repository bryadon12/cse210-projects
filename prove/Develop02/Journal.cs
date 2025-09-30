using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    public string filename = "journal.txt";
    public string promptFile = "prompts.txt";

    public string[] _prompts;

    public int promptNumber = 0;

    public void addEntry(Entry entry)
    {
        _journal.Add(entry);
        promptNumber++;
        if (promptNumber == 5)
        {
            promptNumber = 0;
        }
    }

    public int getPromptNumber()
    {
        return promptNumber;
    }

    public void readJournal()
    {

    }

    public List<Entry> getJournal()
    {
        return _journal;
    }

    public string getPrompt(int promptNumber)
    {
        if (_prompts.Length == 0)
        {
            readPrompts();
        }
        return _prompts[promptNumber];
    }
        public void readPrompts()
    {
        _prompts = System.IO.File.ReadAllLines(promptFile);
    }

}