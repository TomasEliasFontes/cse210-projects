public class Simple : Goal {
    public Simple (string name, string description, int points, bool achieved) 
    : base(name, description, points, achieved)
    {
        IsComplete();
    }
    public override int RecordEvent() 
    {
        int returnPoints  = _points;
        return returnPoints;
    }
    public override string WriteInFile() 
    {
        return $"SimpleGoal:{_name},{_description},{_points},{_achieved}";
    }
}