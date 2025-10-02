using System.ComponentModel;

public class Scripture
{
    private Reference _reference;
    private List<Word> _scripture;
    private int wordsHidden;

    public Scripture(Reference reference, List<Word> scripture)
    {
        _reference = reference;
        _scripture = scripture;
    }


}