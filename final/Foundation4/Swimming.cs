
public class Swimming : Activity
{

    // This are the name that are called in private 
    // in this program so as not to confuse with other variables
    private double _laps;

    public Swimming(string date, int minutes, int laps) : base(date, minutes)
    {
        _name = "Swimming";
        _laps = laps;
    }

    // We get values that are require from this funcion and the information specific to that event type.
    public override double GetDistance()
    {
        double distance = _laps * 50 / 1000;
        return distance;
    }

    public override double GetSpeed()
    {
        double speed = (GetDistance() / _minutes) * 60;
        return speed;
    }

    public override double GetPace()
    {
        double pace = _minutes / GetDistance();
        return pace;
    }
}