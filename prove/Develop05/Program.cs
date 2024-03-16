using System;
using System.Runtime.CompilerServices;

// To exceed the requirements I added a reward shop that the user can add rewards they want to reward themselves for 
// completing goals.

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
        while (selection != 7)
        {

            //Display Main Menu
            Console.Write(
                "\nYou have " + score + " points.\n" +
                "\nMenu Options:" +
                "\n1. Create New Goal" +
                "\n2. List Goals" +
                "\n3. Save Data" +
                "\n4. Load Data" +
                "\n5. Record Event" +
                "\n6. Visit Reward Shop" +
                "\n7. Quit" +
                "\nSelect a choice from the menu: ");

            //Get user input
            selection = int.Parse(Console.ReadLine());
            switch (selection)
            {

                //Create New Goal
                case 1:

                    //Get what type of goal to create 
                    Console.WriteLine(
                        "\nThe types of goals are:" +
                        "\n1. Simple Goal" +
                        "\n2. Eternal Goal" +
                        "\n3. Checklist Goal");
                    Console.Write("Which type of goal would you like to create? ");
                    int goaltype = int.Parse(Console.ReadLine());

                    //Simple Goal
                    if (goaltype == 1)
                    {

                        //Ask for name, description, and points and add goal to list
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        goals.Add(new SimpleGoal(goalName, goalDescription, points, false));
                    }

                    //Eternal Goal
                    else if (goaltype == 2)
                    {

                        //Ask for name, description, and points and add goal to list
                        Console.Write("What is the name of your goal? ");
                        string goalName = Console.ReadLine();
                        Console.Write("What is a short description of it? ");
                        string goalDescription = Console.ReadLine();
                        Console.Write("What is the amount of points associated with this goal? ");
                        int points = int.Parse(Console.ReadLine());
                        goals.Add(new EternalGoal(goalName, goalDescription, points));
                    }

                    //Checklist Goal
                    else if (goaltype == 3)
                    {

                        //Ask for name, description, points, bonus points, and bonus count and add goal to list
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
                        goals.Add(new ChecklistGoal(goalName, goalDescription, points, bonusPoints, bonusCount, 0, false));
                    }
                    break;
                case 2:

                    //Display list of goals
                    Console.WriteLine("\nThe goals are: ");
                    foreach (Goal goal in goals)
                    {
                        goal.DisplayGoalList();
                    }
                    break;
                case 3:

                    //Set score and save data to file
                    file.SetScore(score);
                    file.SaveData(goals, pointShop.GetItems());
                    break;
                case 4:

                    //Load data from file and set goal list, item list, and score
                    file.LoadData();
                    goals = file.GetGoals();
                    pointShop.SetItems(file.GetItems());
                    score = file.GetScore();
                    break;

                case 5:

                    //Display list of goals and get user input
                    Console.WriteLine("The goals are: ");
                    int goalIndex = 1;
                    foreach (Goal goal in goals)
                    {
                        Console.WriteLine(goalIndex + ". " + goal.DisplayGoalName());
                        goalIndex++;
                    }
                    Console.Write("Which goal did you accomplish? ");
                    int goalSelector = int.Parse(Console.ReadLine());

                    //Record event of goal user selected
                    score += goals[goalSelector - 1].RecordEvent();

                    break;

                case 6:

                    //Give Reward shop the points and display menu
                    pointShop.SetScore(score);
                    pointShop.DisplayShopMenu();
                    score = pointShop.GetScore();
                    break;
                default:
                    break;


            }
        }

    }
}