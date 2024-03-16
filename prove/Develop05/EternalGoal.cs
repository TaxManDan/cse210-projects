public class EternalGoal : Goal
{
    public EternalGoal(string name, string description, int points) : base("EternalGoal", name, description, points, false)
    {

    }

    //Returns points for completing the goal
    public override int RecordEvent()
    {
        return _points;
    }

    //Returns defualt DisplayGoalList string
    public override void DisplayGoalList()
    {
        base.DisplayGoalList();
    }

    //Returns defualt PrepareSave string
    public override string PrepareSave()
    {
        return base.PrepareSave();
    }

}