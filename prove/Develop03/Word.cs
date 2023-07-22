public class Word
{
    private string _text;
    public int Index;
    public bool _hidden;

    public Word(string text, int index)
    {
        _text = text;
        Index = index;
        _hidden = false;
    }

    public void Hide()
    {
        _hidden = true;
    }
    
    public override string ToString()
    {
        
            return _text;
        
    }

}