public class SimpleGoal: Goal {
    public SimpleGoal(string name, string description, int points, bool isComplete): base("SimpleGoal",name,description,points, isComplete){

    }
    public override int RecordEvent(){
        return base.RecordEvent();
    }
    public override void DisplayGoalList(){
    if (_isCompleted == false){
        Console.WriteLine($"[ ] {_goalName} ({_goalDescription})");
    }
    else{
        Console.WriteLine($"[X] {_goalName} ({_goalDescription})");
    }
    }

    public override bool IsComplete()
    {
        return base.IsComplete();
    }
    public override string PrepareSave()
    {
        return $"{base.PrepareSave()},{_isCompleted}";
    }
}