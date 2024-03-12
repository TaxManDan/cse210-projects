public class ChecklistGoal: Goal{

    private int _count;
    private int _bonusPoints;
    private int _bonusCount;
    
    public ChecklistGoal( string name, string description, int point, int bonusPoints,int bonusCount, int count): base( "ChecklistGoal",name, description, point, false){
        _bonusCount = bonusCount;
        _bonusPoints = bonusPoints;
        _count = count;
    }
    public override int RecordEvent()
    {
        if (_isCompleted == true){
            _count = 0;
        }
        _count += 1;
        if (_count == _bonusCount){
            _points += _bonusPoints;
            _isCompleted = true;
        }
        return _points;
    }
    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override void DisplayGoalList()
    {
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription}) -- Currently completed:{_count}/{_bonusCount}");
    }
    public override string PrepareSave()
    {
        return $"{base.PrepareSave()},{_bonusPoints},{_bonusCount},{_count}";
    }
}