using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture;
    private int _wordsHidden;
    private Random _random;

    public Scripture(Reference reference, List<Word> scripture)
    {
        _reference = reference;
        _scripture = scripture;
        _wordsHidden = 0;
        _random = new Random();
    }

    public void ShowScripture()
    {
        foreach (Word word in _scripture)
        {
            word.GetWord();
        }
    }
    public bool HideWords()
    {
        return HideWords(_scripture, _wordsHidden);
    }

    public bool HideWords(List<Word> scripture, int wordsHidden)
    {
        do
        {
            int i = _random.Next(0, scripture.Count);
            if (scripture[i].IsShowing())
            {
                scripture[i].HideWord();
                wordsHidden++;
            }
            else
            {
                continue;
            }
        }
        while ((wordsHidden < _wordsHidden + scripture.Count / 5) || (wordsHidden == scripture.Count));
        return (wordsHidden == scripture.Count);
    }
}