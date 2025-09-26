public class Prompt
{
    public string[] _prompts;
    public int currentPrompt = 0;

    public string filename = "prompts.txt";
    public void getPrompt()
    {
        Console.WriteLine(_prompts[currentPrompt]);
        iteratePrompt();
    }

    public void iteratePrompt()
    {
        if (currentPrompt == 4)
        {
            currentPrompt = 0;
        }
        else
        {
            currentPrompt++;
        }
    }

    public void readPrompts(string filename)
    {
        String[] prompts = System.IO.File.ReadAllLines(filename);
        _prompts = prompts;
    }
}