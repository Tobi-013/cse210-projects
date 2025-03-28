public class Reference
{
    private string _book;
    private int _startChapter;
    private int _startVerse;
    private int? _endChapter;  
    private int? _endVerse;

    public Reference(string book, int startChapter, int startVerse, int? endChapter = null, int? endVerse = null)
    {
        _book = book;
        _startChapter = startChapter;
        _startVerse = startVerse;
        _endChapter = endChapter;
        _endVerse = endVerse;
    }

    public string GetFormattedReference()
    {
        if (_endChapter == null && _endVerse == null)
        {
            return $"{_book} {_startChapter}:{_startVerse}";
        }
        else
        {
            return $"{_book} {_startChapter}:{_startVerse}-{_endChapter}:{_endVerse}";
        }
    }
}
