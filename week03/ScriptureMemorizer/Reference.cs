public class Reference
{
    private string _book;
    private string _chapter;
    private string _verse;
    private int _endVerse;

    public Reference(string book, int chapter, int verse)
    {
        
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        _book = book;
        _chapter = chapter.ToString();
        _verse = verse.ToString();
        _endVerse = endVerse;
    }

    public string GetDisplayText()
    {
        return $"{_book} {_chapter}:{_verse}";
    }
}