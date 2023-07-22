
public class Reference
{

    private string _book;
    private int _chapter;
    private int _verseStart;
    private int _verseEnd;

    public Reference(string book, int chapter, int verse)
    {
        _book = book;
        _chapter = chapter;
        _verseStart =verse;

    } 

    public string getReference()
    {

        return $"{_book}{_chapter}:{_verseStart}";

    }

}