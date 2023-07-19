using System;

public class Activity
{
    // We use protected to use in this funcion and to not have a problem 
    protected string _date;
    protected int _minutes;
    protected string _name;
    protected double _value;

    // Here we call the principal funcion of the program Activity
    // that calls the date and minutes of the activity
    public Activity(string date, int minutes)
    {
        _date = date;
        _minutes = minutes;
    }

    // This is how is gonna we displey the value that we call in the funcion in the other programs
    // Distance, speed, pace and the all info for the user in the system(Program.cs)
    public virtual double GetDistance()
    {
        return _value;
    }

    public virtual double GetSpeed()
    {
        return _value;
    }

    public virtual double GetPace()
    {
        return _value;
    }

    public string GetSummary()
    {
        string summary = $"{_date} {_name} ({_minutes} min)- Distance {GetDistance()} km, Speed: {GetSpeed()} kph, Pace: {GetPace()} min per km";
        return summary;
    }
}