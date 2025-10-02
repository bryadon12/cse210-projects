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

    public string GetWord()
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

    public bool IsShowing()
    {
        return _showing;
    }
}