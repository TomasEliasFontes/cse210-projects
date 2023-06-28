public class Reference
{
    private string book;
    private int chapter;
    private int verse;
    private int endVerse;

    public Reference(string _book, int _chapter, int _verse)
    {
        book = _book;
        chapter = _chapter;
        verse = _verse;
    }
    public Reference(string _book, int _chapter, int _verseStar, int _verseEnd)
    {
        book = _book;
        chapter = _chapter;
        verse = _verseStar;
        endVerse = _verseEnd;
    }
    public string GetDisplayText()
    {
        string referenceDisplay ="";
        if (endVerse != 0)
        {
            referenceDisplay = $"{book} {chapter}:{verse}-{endVerse}";
        }
        else
        {
            referenceDisplay = $"{book} {chapter}:{verse}";

        }

        return referenceDisplay;
    }

}