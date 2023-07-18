

public class OutdoorGathering : Event
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private string _weatherForecast;

    public OutdoorGathering( string type, string title, string description, string date, string time, Address address, string weatherForecast ) : base( type, title, description,date,time,address)
    {       
        _weatherForecast = weatherForecast;
    }

    // Get the full Details of information specific to that event type.
    public void FullDetails()
    {
        base.FullDetails();
        Console.WriteLine($"Weather forecast : {_weatherForecast} ");        
    } 


}
