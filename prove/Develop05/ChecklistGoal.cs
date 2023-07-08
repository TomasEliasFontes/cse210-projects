
public class Checklist : Goal {

    public Checklist (string goal, string description, int points) : base(goal, description, points)
    {
        
        if (points == 0) {_achieved = true;}
    }

    public override int RecordEvent() 
    {
        int returnPoints = 0;
 
        returnPoints += _points;
        return returnPoints;
    }
    public override void DisplayGoal() 
    {

        string checkBox = "[ ]";
        if (_achieved) {
            checkBox ="[X]";
        }

        Console.WriteLine($"{checkBox} {_name} ({_description})");
    }
    public override string WriteInFile()
    {
        return $"ChecklistGoal:{_name},{_description},{_points}";
    }
}