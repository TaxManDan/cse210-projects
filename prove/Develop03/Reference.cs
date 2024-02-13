public class Reference
{
    private string _book;
    private string _chapter;
    private string _startVerse;
    private string _endVerse = "0";

    public Reference(string book, string chapter, string verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
    }
    public Reference(string book, string chapter, string start, string end)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = start;
        _endVerse = end;
    }
    public string DisplayReference()
    {
        // Check if there is an end verse
        if (_endVerse != "0")
        {
            return $"{_book} {_chapter}:{_startVerse}-{_endVerse}";
        }
        else
        {
            return $"{_book} {_chapter}:{_startVerse}";
        }

    }
}