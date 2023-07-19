

public class Bicycles : Activity
{
    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    protected double _speed;

    public Bicycles(string date, int minutes, double speed) : base(date, minutes)
    {
        _name = "Stationary Bicycles";
        _speed = speed;
    }
    
    // We get values that are require from this funcion and the information specific to that event type.
    public override double GetDistance()
    {
        double distance = _speed * _minutes;
        return distance;
    }

    public override double GetSpeed()
    {
        return _speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / GetDistance();
        return pace;
    }
}