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
        Console.Clear();
        _reference.printReference();
        foreach (Word word in _scripture)
        {
            Console.Write($"{word.GetWord()} ");
        }
    }
    public bool HideWords()
    {
        int startingHidden = _wordsHidden;
        do
        {
            int i = _random.Next(0, _scripture.Count);
            if (_scripture[i].IsShowing())
            {
                _scripture[i].HideWord();
                _wordsHidden++;
            }
        }
        while ((_wordsHidden < startingHidden + (_scripture.Count / 5)) && (_wordsHidden < _scripture.Count));
        return (_wordsHidden == _scripture.Count);
    }
}