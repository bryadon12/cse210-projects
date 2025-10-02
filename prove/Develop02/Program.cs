using System.IO; 
class Program
{
    static void Main(string[] args)
    {
        string filename = "journal.txt";
        Journal journal = new Journal();
        Menu menu = new Menu();
        do
        {
            menu.openMenu();
            int option = int.Parse(menu.selectOption());

            if (option == 1)
            {
                journal.addEntry(writeEntry(journal)); 
            }
            else if (option == 2)
            {
                displayJournal(journal);
            }
            else if (option == 3)
            {
                saveJournal(journal, filename);
            }
            else if (option == 4)
            {
                loadJournal(journal, filename);
            }
            else
            {
                return;
            }
        } while (1 == 1);
    }

    public static Entry writeEntry(Journal journal)
    {
        string prompt = journal.getPrompt();
        Console.WriteLine(prompt);
        string response = Console.ReadLine();
        Console.WriteLine("Please Enter Today's Date: ");
        string date = Console.ReadLine();
        Entry entry = new Entry(date, response, prompt);
        return entry;
    }

    public static void displayJournal(Journal journal)
    {
        foreach (Entry entry in journal.getJournal())
        {
            Console.WriteLine(entry.getEntry());
        }
    }

    public static void saveJournal(Journal journal, string filename)
    {
        using (StreamWriter outputFile = new StreamWriter(filename))
        {
            foreach (Entry entry in journal.getJournal())
                outputFile.WriteLine(entry.getEntry());
        }
    }

    public static void loadJournal(Journal journal, string filename)
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
