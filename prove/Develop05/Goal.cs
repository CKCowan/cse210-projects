using System.ComponentModel;

public abstract class Goal
{
    public string _shortName;
    public string _description;
    public int _points;
    public string _type;

    public Goal (string name, string description, int points, string type)
    {
        _shortName = name;
        _description = description;
        _points = points;
    }
    public abstract void RecordEvent();
    public abstract bool IsComplete();

    // This method should return the details of a goal that could be shown in a list. It should include the checkbox, the short name, and description. Then in the case of the ChecklistGoal class, it should be overridden to shown the number of times the goal has been accomplished so far.
    public virtual string GetDetailsString(){
        return $"{_shortName} ({_description})";
    }

    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    public abstract string GetStringRepresentation(string name, string description, int points);
}