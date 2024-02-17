using System.ComponentModel;

public class Simple : Goal
{
    private bool _isComplete;

    public Simple(string name, string description, int points, string type) : base(name, description, points)
    {
        _isComplete = false;
    }

    // This method should do whatever is necessary for each specific kind of goal, such as marking a simple goal complete and adding to the number of times a checklist goal has been completed. It should return the point value associated with recording the event (keep in mind that it may contain a bonus in some cases if a checklist goal was just finished, for example).

    public override void RecordEvent()
    {
        
    }

    // This method should return true if the goal is completed. The way you determine if a goal is complete is different for each type of goal.
    public override bool IsComplete()
    {
        if(_isComplete){
            return true;
        }
        else{
            return false;
        }
    }

    // This method should provide all of the details of a goal in a way that is easy to save to a file, and then load later.
    public override string GetStringRepresentation(string name, string description, int points)
    {
        return $"SimpleGoal:{name},{description},{points},{_isComplete}";
    }
}