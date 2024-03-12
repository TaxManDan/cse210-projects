public class EternalGoal : Goal{
    public EternalGoal(string name, string description, int points) : base("EternalGoal", name, description, points, false){

    }
    public override int RecordEvent()
    {
        return _points;
    }
    public override void DisplayGoalList()
    {
        base.DisplayGoalList();
    }
    public override string PrepareSave()
    {
        return base.PrepareSave();
    }
    public override bool IsComplete()
    {
        return false;
    }
}