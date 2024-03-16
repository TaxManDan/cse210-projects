public class SimpleGoal : Goal
{
    public SimpleGoal(string name, string description, int points, bool isComplete) : base("SimpleGoal", name, description, points, isComplete)
    {

    }


    public override int RecordEvent()
    {

        // Checks if Goal is already completed
        if (_isCompleted == false)
        {

            // If goal is not completed, record the event
            return base.RecordEvent();
        }
        else
        {
            // If goal is already completed, inform user and return 0
            Console.WriteLine("Goal already completed");
            return 0;
        }
    }
    public override void DisplayGoalList()
    {

        // Checks if Goal is already completed and if it is mark as completed
        if (_isCompleted == false)
        {
            Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
        }
        else
        {
            Console.WriteLine($"[X] {_goalName} ({_goalDescription})");
        }
    }


    // Returns the default PepareSave string and _isCompleted
    public override string PrepareSave()
    {
        return $"{base.PrepareSave()},{_isCompleted}";
    }
}