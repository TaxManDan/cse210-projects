using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        List<Goal> goals = new List<Goal>();
        var pointShop = new PointShop();
        var file = new File();
        int selection = 0;
        int score = 0;
        while (selection != 7){
            Console.Write(
                "\nYou have " + score + " points.\n"+
                "\nMenu Options:"+
                "\n1. Create New Goal"+
                "\n2. List Goals"+
                "\n3. Save Goals"+
                "\n4. Load Goals"+
                "\n5. Record Event"+
                "\n6. Visit Point Shop" +
                "\n7. Quit"+
                "\nSelect a choice from the menu: ");
            selection = int.Parse(Console.ReadLine());
            switch (selection){
            case 1:
                Console.WriteLine(
                    "\nThe types of goals are:"+
                    "\n1. Simple Goal"+
                    "\n2. Eternal Goal"+
                    "\n3. Checklist Goal");
                Console.Write("Which type of goal would you like to create? ");
                int goaltype = int.Parse(Console.ReadLine());
                if (goaltype == 1) {
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    goals.Add(new SimpleGoal(goalName,goalDescription,points, false));
                }
                else if (goaltype == 2){
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    goals.Add(new EternalGoal(goalName,goalDescription,points));
                }
                else if (goaltype == 3){
                    Console.Write("What is the name of your goal? ");
                    string goalName = Console.ReadLine();
                    Console.Write("What is a short description of it? ");
                    string goalDescription = Console.ReadLine();
                    Console.Write("What is the amount of points associated with this goal? ");
                    int points = int.Parse(Console.ReadLine());
                    Console.Write("How many times does this goal need to be accomplished for a bonus? ");
                    int bonusCount = int.Parse(Console.ReadLine());
                    Console.Write("What is the bonus for accomplishing it that many times? ");
                    int bonusPoints = int.Parse(Console.ReadLine());
                    goals.Add(new ChecklistGoal(goalName,goalDescription,points,bonusPoints,bonusCount,0));
                }
                break;
            case 2:
                Console.WriteLine("\nThe goals are: ");
                foreach (Goal goal in goals){
                    goal.DisplayGoalList();
                }
                break;
            case 3:
                file.SetScore(score);
                file.SaveGoals(goals);
                break;
            case 4:
                goals = file.LoadGoals();
                score = file.GetScore();
                break;

            case 5:
                Console.WriteLine("The goals are: ");
                int goalIndex = 1;
                foreach (Goal goal in goals){
                    Console.WriteLine( goalIndex + ". " +goal.DisplayGoalName());
                    goalIndex++;
                }
                Console.Write("Which goal did you accomplish? ");
                int goalSelector = int.Parse(Console.ReadLine());
                score += goals[goalSelector-1].RecordEvent();

                break;

            case 6:
                pointShop.SetScore(score);
                pointShop.DisplayShopMenu();
                break;
            default:
                break;


            }
        }

    }
}