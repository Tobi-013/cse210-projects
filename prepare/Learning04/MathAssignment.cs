public class MathAssignment : Assignment
{
   private string _textbookSection;
   private string _problems;

    public MathAssignment(string textbooksection, string problems,string studentName, string topic) : base(studentName, topic)
    {
        _textbookSection = textbooksection;
        _problems = problems;
    }
   public string GetHomeworkList()
    {
        return $"Section{_textbookSection} Problems{_problems}";
    }

}