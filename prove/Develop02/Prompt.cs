public class Prompt
{
    public string[] _prompts;
    public int promptNumber = 0;

    // public string filename = "prompts.txt";
    public void getPrompt()
    {
        Console.WriteLine(_prompts[promptNumber]);

    }
        public void readPrompts(string filename)
    {
        String[] prompts = System.IO.File.ReadAllLines(filename);
        _prompts = prompts;
    }

    // public void iteratePrompt()
    // {
    //     if (currentPrompt == 4)
    //     {
    //         currentPrompt = 0;
    //     }
    //     else
    //     {
    //         currentPrompt++;
    //     }
    // }
}