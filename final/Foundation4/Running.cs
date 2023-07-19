
public class Running : Activity
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private double _distance;

    public Running(string date, int minutes, double distance) : base(date, minutes)
    {
        _name = "Running";
        _distance = distance;
    }
    
    // We get values that are require from this funcion and the information specific to that event type.
    public override double GetDistance()
    {
        return _distance;
    }

    public override double GetSpeed()
    {
        double speed = (_distance / _minutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / _distance;
        return pace;
    }
}