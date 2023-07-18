

public class Lecture : Event
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private int _limitCapacity;
    private string _speaker;

    public Lecture( string type,string title, string description, string date, string time, Address address, string speaker, int limitCapacity ) : base(type,title, description,date,time,address)
    {
        _speaker = speaker;
        _limitCapacity = limitCapacity;
    }

    // Get the full Details of information specific to that event type.
    public void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Speaker : {_speaker} Availability people : {_limitCapacity}");
    } 

}
