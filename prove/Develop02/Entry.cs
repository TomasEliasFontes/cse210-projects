
// We add public to the general class of the Entry 
// to may be accessible to the other programs
public class Entry
{

    // This are the name that are called in public 
    // in others programs and are designated another format for the program
    public string date, promptText, entryText;
    public Entry (string _date, string _entryText, string _promptText)
    {
        date = _date;
        entryText = _entryText;
        promptText = _promptText;

    }

    // THis is how is gonna we displey the info input from the user 
    // in case is asked
    public void Display()
    {
        Console.WriteLine($"Date: {date} - Prompt: {promptText} ");
        Console.WriteLine(entryText);    
    }
}