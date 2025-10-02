public class Menu
{
    public Journal _journal;
    public string _filename = "journal.txt";
    public Menu(Journal journal)

    {
        _journal = journal;
    }
    public void openMenu()
    {
        Console.WriteLine("1. Write New Entry\n2. Display Journal\n3. Save Journal\n4. Load Journal\n(Select 1-4, or 0 to exit)");
    }

    public void selectOption()
    {
        int option = int.Parse(Console.ReadLine());

        if (option == 1)
        {
            _journal.addEntry(writeEntry(_journal));
        }
        else if (option == 2)
        {
            displayJournal(_journal);
        }
        else if (option == 3)
        {
            saveJournal(_journal, _filename);
        }
        else if (option == 4)
        {
            loadJournal(_journal, _filename);
        }
        else
        {
            return;
        }
        openMenu();
    }

    public Entry writeEntry(Journal journal)
    {
        string prompt = journal.getPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Console.WriteLine("Please Enter Today's Date: ");
        string date = Console.ReadLine();
        Entry entry = new Entry(date, response, prompt);
        return entry;
    }

    public void displayJournal(Journal journal)
    {
        foreach (Entry entry in journal.getJournal())
        {
            Console.WriteLine(entry.getEntry());
        }
    }

    public void saveJournal(Journal journal, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journal.getJournal())
                outputFile.WriteLine(entry.getEntry());
        }
    }

    public void loadJournal(Journal journal, string filename)
    {
        string[] lines = System.IO.File.ReadAllLines(filename);
        foreach (string line in lines)
        {
            string[] parts = line.Split(":");
            string prompt = parts[0];
            parts = parts[1].Split("(");
            string response = parts[0];
            string date = parts[1];
            journal.addEntry(new Entry(date, response, prompt));
        }
    }
}