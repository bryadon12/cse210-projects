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

    public string getWord()
    {
        if (_showing)
        {
            return _word;
        }
        else
        {
            return new string('_', _word.Length);
        }
    }
}