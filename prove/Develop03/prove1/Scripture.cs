using System;
class Scripture
{
    private List<Word> words;
    private Reference reference;
    
    
    public Scripture(Reference _reference, string _text)
    {
        reference = _reference;
        words = new List<Word>();

        List<string> allwords = _text.Split(' ').ToList();
        foreach(string wordS in allwords)
        {
            Word newWord = new Word(wordS);
            words.Add(newWord);
        }

    }
    public void HideRandomeWords()
    {
 
           
    }
    
    public string GetDisplayText()
    {
        string scriptureText = "";

        foreach(Word word in words)
        {
            if (word.GetIsHidden()== false)
            {
                scriptureText += word.GetDisplayText() + " ";

            }

            else
            {
                scriptureText += new string('_',word.GetDisplayText().Length) + " ";
            }
        }
        return ($"{reference.GetDisplayText()} {scriptureText}");
        
    }
    public bool IsCompletelyHidden()
    {

        return true;
    }

}