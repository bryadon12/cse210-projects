public class Word
{
    private string _word;
    private bool _showing;

    public Word(string word)
    {
        _showing = true;
        _word = word;
    }

    public void HideWord()
    {
        _showing = false;
    }
}