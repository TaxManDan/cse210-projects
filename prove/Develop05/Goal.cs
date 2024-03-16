public class Goal
{
    protected string _goalName;
    protected string _goalType;
    protected int _points;
    protected string _goalDescription;
    protected bool _isCompleted;

    public Goal(string type, string name, string description, int points, bool completed)
    {
        _goalType = type;
        _goalName = name;
        _goalDescription = description;
        _points = points;
        _isCompleted = completed;
    }


    // Returns name of Goal
    public string DisplayGoalName()
    {
        return _goalName;
    }

    //Default display goal
    public virtual void DisplayGoalList()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }



    // Default prepare save
    public virtual string PrepareSave()
    {
        return $"{_goalType}:{_goalName},{_goalDescription},{_points}";
    }

    //Default record event
    public virtual int RecordEvent()
    {
        _isCompleted = true;
        return _points;
    }
}