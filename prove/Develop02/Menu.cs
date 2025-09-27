public class Menu
{
    public void openMenu()
    {
        Console.WriteLine("1. Write New Entry\n2. Display Journal\n3. Save Journal\n4. Load Journal\n(Enter 1-4)");
        readMenu();
    }

    public void readMenu()
    {
        int option = int.Parse(Console.ReadLine());
        if (option == 1)
        {
            int promptNum = 1;
            writeEntry(promptNum);
        }
        else if (option == 2)
        {
            displayJournal();
        }
        else if (option == 3)
        {
            saveJournal();
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

    public void writeEntry(int promptNum)
    {
        Entry entry = new Entry();
    }

    public void displayJournal()
    {
        
    }

    public void saveJournal()
    {

    }

    public void loadJournal()
    {

    }
}

// Write a new entry - Show the user a random prompt (from a list that you create), and save their response, the prompt, and the date as an Entry.
// Display the journal - Iterate through all entries in the journal and display them to the screen.
// Save the journal to a file - Prompt the user for a filename and then save the current journal (the complete list of entries) to that file location.
// Load the journal from a file - Prompt the user for a filename and then load the journal (a complete list of entries) from that file. This should replace any entries currently stored in the journal.
// Provide a menu that allows the user choose these options