public class Goal{
    protected string _goalName;
    protected string _goalType;
    protected int _points;
    protected string _goalDescription;
    protected bool _isCompleted;

    public Goal(string type, string name, string description, int points, bool completed){
        _goalType = type;
        _goalName = name;
        _goalDescription = description;
        _points = points;
        _isCompleted = completed;
    }
    
    public string DisplayGoalName(){
        return _goalName;
    }
    public virtual void DisplayGoalList(){
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }
    public virtual bool IsComplete(){
        return _isCompleted;
    }
    public virtual string PrepareSave(){
        return $"{_goalType}:{_goalName},{_goalDescription},{_points}";
    }
    public virtual int RecordEvent(){
        _isCompleted = true;
        return _points;
    }
}