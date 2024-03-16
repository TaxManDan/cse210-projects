public class ChecklistGoal : Goal
{

    private int _count;
    private int _bonusPoints;
    private int _bonusCount;

    public ChecklistGoal(string name, string description, int point, int bonusPoints, int bonusCount, int count, bool complete) : base("ChecklistGoal", name, description, point, complete)
    {
        _bonusCount = bonusCount;
        _bonusPoints = bonusPoints;
        _count = count;
    }
    public override int RecordEvent()
    {
        //Check if goal is completed
        if (_isCompleted == true)
        {
            //If goal is completed, reset the counter
            _count = 0;
            _isCompleted = false;
        }
        //Increment the counter
        _count += 1;
        //Check if goal count is equal to bonus count
        if (_count == _bonusCount)
        {
            //If goal count is equal to bonus count, mark as complete and return bonus points 
            _isCompleted = true;
            return _points + _bonusPoints;
        }
        else
        {
            //If goal count is not equal to bonus count, return normal points
            return _points;
        }
    }

    public override void DisplayGoalList()
    {

        //Mark if goal is completed
        if (!_isCompleted)
        {
            Console.WriteLine($"[ ] {_goalName} ({_goalDescription}) -- Currently completed:{_count}/{_bonusCount}");
        }
        else
        {
            Console.WriteLine($"[X] {_goalName} ({_goalDescription}) -- Currently completed:{_count}/{_bonusCount}");
        }
    }

    // Returns default PrepareSave string along with bonus points, bonus count, current count, and if goal is completed.
    public override string PrepareSave()
    {
        return $"{base.PrepareSave()},{_bonusPoints},{_bonusCount},{_count},{_isCompleted}";
    }
}