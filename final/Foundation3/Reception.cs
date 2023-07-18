

public class Reception : Event
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private string _peopleRSVP;   
    
    public Reception(string type, string eventTitle, string description, string eventDate, string eventTime, Address address, string peopleRSVP) : base(type,eventTitle, description,eventDate,eventTime,address)
    {
        _peopleRSVP = peopleRSVP;
    }

    
    // Get the full Details of information specific to that event type.
    public void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Email for RSVP : {_peopleRSVP} ");
    }    



}
