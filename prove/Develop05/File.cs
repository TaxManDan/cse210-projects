using System.IO.Enumeration;

public class File{
    private int _score;

    public void SetScore(int score){
        _score = score;
    }

    public List<Goal> LoadGoals(){
        var Goals = new List<Goal>();
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");
        _score = int.Parse(lines[0]);
        for (int i = 1 ; i < lines.Length;i++ ){
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            Goal goal = null;
            if (goalType == "SimpleGoal"){
                string goalName = parts[1].Split(",")[0];
                string goalDescription = parts[1].Split(",")[1];
                int points = int.Parse(parts[1].Split(",")[2]);
                bool isCompleted = bool.Parse(parts[1].Split(",")[3]);
                goal = new SimpleGoal(goalName,goalDescription,points,isCompleted);
            }
            else if (goalType == "EternalGoal"){
                string goalName = parts[1].Split(",")[0];
                string goalDescription = parts[1].Split(",")[1];
                int points = int.Parse(parts[1].Split(",")[2]);
                goal = new EternalGoal(goalName,goalDescription,points);
            }
            else if (goalType == "ChecklistGoal"){
                string goalName = parts[1].Split(",")[0];
                string goalDescription = parts[1].Split(",")[1];
                int points = int.Parse(parts[1].Split(",")[2]);
                int bonusPoints = int.Parse(parts[1].Split(",")[3]);
                int bonusCount = int.Parse(parts[1].Split(",")[4]);
                int count = int.Parse(parts[1].Split(",")[5]);
                goal = new ChecklistGoal(goalName,goalDescription,points,bonusPoints,bonusCount,count);
            }
            Goals.Add(goal);
        }
            return Goals;

    }
    public void SaveGoals(List<Goal> goals){
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt")){
        outputFile.WriteLine(_score);
        foreach (Goal goal in goals){
            outputFile.WriteLine(goal.PrepareSave());
        }

        }
    }
    public int GetScore(){
        return _score;
    }
}