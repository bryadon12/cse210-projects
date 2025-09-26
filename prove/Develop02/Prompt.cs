public class Prompt
{
    private List<string> _prompts = new List<string>();
    private int currentPrompt = 0;
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

    public void readPrompts(string fileName)
    {

    }
}