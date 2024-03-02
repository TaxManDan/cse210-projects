using System;

// To exceed the requirements I have added a log that saves and loads from a csv file. 
// I have also made it so all the prompts and questions have to be chosen at least once until it repeats in the session.

class Program
{
    static void Main(string[] args)
    {
        // Create new activities instances
        int sel = 0;
        var breathe = new BreathingActivity();
        var reflect = new ReflectingActivity();
        var list = new ListingActivity();

        while (sel != 5)
        {
            
            // Display menu
            Console.Clear();
            Console.Write(
                "Menu Options:" +
                "\n\n1. Start breathing activity" +
                "\n2. Start reflecting activity" +
                "\n3. Start listing activity" +
                "\n4. View Log" +
                "\n5. Quit" +
                "\n\nSelect a choice from the menu: ");

            // Get user input
            sel = int.Parse(Console.ReadLine());

            switch (sel)
            {
                case 1:

                    // Start breathing activity
                    breathe.DisplayStartMessage();
                    breathe.StartBreathing();
                    breathe.DisplayEndMessage();
                    break;
                case 2:

                    // Start reflecting activity
                    reflect.DisplayStartMessage();
                    reflect.StartReflecting();
                    reflect.DisplayEndMessage();
                    break;
                case 3:

                    // Start listing activity
                    list.DisplayStartMessage();
                    list.StartListing();
                    list.DisplayEndMessage();
                    break;
                case 4:

                    // View Log
                    Console.Clear();
                    string[] lines = System.IO.File.ReadAllLines($"log.csv");
                    
                    // For each line, split parts and display the log information
                    foreach (string line in lines)
                    {
                        string[] parts = line.Split("\",\"");
                        string logDate = parts[0].Trim('"');
                        string logActivity = parts[1];
                        string logDuration = parts[2].TrimEnd('"');
                        Console.WriteLine("Date and Time: " + logDate + " - Activity: " + logActivity + " - Duration: " + logDuration);
                    }
                    Console.Write("\nPress Enter to continue...");
                    Console.ReadLine();
                    break;
                default:
                    break;
            }
        }
    }
}