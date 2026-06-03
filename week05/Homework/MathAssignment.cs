public class MathAssignment : Assignment
{
    private string _textbookSelection;
    private string _problems;
    public MathAssignment(string name, string topic, string textbookSelection, string problems) : base(name, topic)    {
        _textbookSelection = textbookSelection;
        _problems = problems;
        
    }
    public string GetHomeworkList()
    {
        return $"{_textbookSelection} - {_problems}";
    }
}