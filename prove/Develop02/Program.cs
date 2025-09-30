using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "prompts.txt";
        Journal journal = new Journal();
        Menu menu = new Menu();

        menu.openMenu();
        int option = int.Parse(menu.selectOption());
        
                if (option == 1)
            {
                journal.addEntry(writeEntry(journal));
            }
            else if (option == 2)
            {
                displayJournal();
            }
            else if (option == 3)
            {
                saveJournal(journal, filename);
            }
            else if (option == 4)
            {
                loadJournal();
            }
            else
            {
                return;
            }
    }

    public static Entry writeEntry(Journal journal)
    {
        Entry entry = new Entry();
        entry._prompt = journal.getPrompt();
        Console.WriteLine(entry._prompt);
        entry._response = Console.ReadLine();
        Console.WriteLine("Please Enter Today's Date: ");
        entry._date = Console.ReadLine();
        return entry;
    }

    public static void displayJournal()
    {

    }

    public static void saveJournal(Journal journal, string filename)
    {
                using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journal.getJournal())
            outputFile.WriteLine(entry.getEntry());
        }
    }

    public static void loadJournal()
    {

    }
}