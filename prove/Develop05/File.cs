using System.IO.Enumeration;
using System.Security.Cryptography.X509Certificates;

public class File
{
    private int _score;
    private List<Item> _items = new List<Item>();
    private List<Goal> _goals = new List<Goal>();

    public void SetScore(int score)
    {
        _score = score;
    }

    public void LoadGoals()
    {
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.txt");
        _score = int.Parse(lines[0]);
        for (int i = 1; i < lines.Length; i++)
        {
            string[] parts = lines[i].Split(":");
            string goalType = parts[0];
            Goal goal = null;
            if (goalType == "SimpleGoal")
            {
                string goalName = parts[1].Split(",")[0];
                string goalDescription = parts[1].Split(",")[1];
                int points = int.Parse(parts[1].Split(",")[2]);
                bool isCompleted = bool.Parse(parts[1].Split(",")[3]);
                goal = new SimpleGoal(goalName, goalDescription, points, isCompleted);
                _goals.Add(goal);
            }
            else if (goalType == "EternalGoal")
            {
                string goalName = parts[1].Split(",")[0];
                string goalDescription = parts[1].Split(",")[1];
                int points = int.Parse(parts[1].Split(",")[2]);
                goal = new EternalGoal(goalName, goalDescription, points);
                _goals.Add(goal);
            }
            else if (goalType == "ChecklistGoal")
            {
                string goalName = parts[1].Split(",")[0];
                string goalDescription = parts[1].Split(",")[1];
                int points = int.Parse(parts[1].Split(",")[2]);
                int bonusPoints = int.Parse(parts[1].Split(",")[3]);
                int bonusCount = int.Parse(parts[1].Split(",")[4]);
                int count = int.Parse(parts[1].Split(",")[5]);
                bool complete = bool.Parse(parts[1].Split(",")[6]);
                goal = new ChecklistGoal(goalName, goalDescription, points, bonusPoints, bonusCount, count,complete);
                _goals.Add(goal);
            }
            else if (goalType == "Item")
            {
                string[] itemParts = parts[1].Split(",");
                string itemName = itemParts[0];
                int itemCost = int.Parse(itemParts[1]);
                int itemQuantity = int.Parse(itemParts[2]);
                int shopQuantity = int.Parse(itemParts[3]);
                Item item = new Item(itemName, itemCost, shopQuantity, itemQuantity);
                _items.Add(item);
            }
            
        }
    }
    public void SaveGoals(List<Goal> goals, List<Item> items)
    {
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
        {
            outputFile.WriteLine(_score);
            foreach (Goal goal in goals)
            {
                outputFile.WriteLine(goal.PrepareSave());
            }
            foreach (Item item in items){
                outputFile.WriteLine(item.PrepareSave());
            }

        }
    }
    public int GetScore()
    {
        return _score;
    }
    public List<Goal> GetGoals(){
        return _goals;
    }

    public List<Item> GetItems(){
        return _items;
    }
}