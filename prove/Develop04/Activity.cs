using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity(string name, string description)
    {
        _name = name;
        _description = description;
    }

    // Display the common start message and get the duration
    public void DisplayStartMessage()
    {
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}  Activity!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }

    // Display the common end message and log the activity
    public void DisplayEndMessage()
    {
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
        LogActivity();
        DisplaySpinner(5);
    }

    // Get the duration of the activity
    public int GetDuration()
    {
        return _duration;
    }
    public void DisplaySpinner(int spins)
    {

        // Display spinner for chosen number of rotations
        for (int i = 0; i < spins; i++)
        {
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("|");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("/");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("-");
            Thread.Sleep(200);
            Console.Write("\b \b");
            Console.Write("\\");
            Thread.Sleep(200);
            Console.Write("\b \b");
        }
    }
    
    // Take a number and start counting down from the number
    public void DisplayCountdown(int start)
    {

        for (int i = start; i > 0; i--)
        {
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
    public void LogActivity()
    {

        // Get current time and date
        DateTime logTime = DateTime.Now;
        // Add a new Line to the log file
        using (StreamWriter outputFile = new StreamWriter($"log.csv", true))
        {
            // Write time activity and duration
            outputFile.WriteLine($"\"{logTime}\",\"{_name}\",\"{_duration}\"");
        }
    }
}