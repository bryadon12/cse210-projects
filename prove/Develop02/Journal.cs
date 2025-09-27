using System.IO;

public class Journal
{
    public List<Entry> _journal = new List<Entry>();
    string filename = "journal.txt";

    public void addEntry(Entry entry)
    {
        _journal.Add(entry);
    }

    public void saveJournal()
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in _journal)
            outputFile.WriteLine(entry.getEntry());
        }

    }
}