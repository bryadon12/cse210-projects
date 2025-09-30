using System;

class Program
{
    static void Main(string[] args)
    {
        string filename = "prompts.txt";
        Journal journal = new Journal();
        Menu menu = new Menu();
        String[] prompts = System.IO.File.ReadAllLines(filename);

        menu.openMenu();
        int option = int.Parse(menu.selectOption());
        
                if (option == 1)
            {
                writeEntry(journal);
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

    public static void writeEntry(Journal journal)
    {
        Entry entry = new Entry();
        journal.getPromptNumber();

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