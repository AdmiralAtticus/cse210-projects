public class Reference
{
    private string _book;
    private int _chapter;
    private int _startVerse;
    private int _EndVerse;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = verse;
        _EndVerse = verse;
    }

    public Reference(string book, int chapter, int startVerse, int endVerse)
    {
        _book = book;
        _chapter = chapter;
        _startVerse = startVerse;
        _EndVerse= endVerse;
    }
    
    public string GetReferenceText()
    {
        if (_startVerse == _EndVerse)
        
            return $"{_book} {_chapter}: {_startVerse}";
        else
            return $"{_book} {_chapter}: {_startVerse}-{_EndVerse}";
                
            
        
    }
}