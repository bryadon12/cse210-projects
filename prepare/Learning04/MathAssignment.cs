public class MathAssignment : Assignment
{
    private string _textbookSelection;
    private string _problems;

    public MathAssignment() : base()
    {
        _textbookSelection = "";
        _problems = "";
    }

    public MathAssignment(string studentName, string title, string textbookSelection, string problems) : base(studentName, title)
    {
        _textbookSelection = textbookSelection;
        _problems = problems;
    }

    public void SetTextbookSelection(string textbookSelection)
    {
        _textbookSelection = textbookSelection;
    }

    public string GetTextbokSelection()
    {
        return _textbookSelection;
    }

    public void SetProblems(string problems)
    {
        _problems = problems;
    }

    public string SetProblems()
    {
        return _problems;
    }

    public string GetHomeworkList()
    {
        return $"{GetSummary()}, Textbook: {_textbookSelection}, Problems: {_problems}";
    }
}