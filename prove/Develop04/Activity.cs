using System.IO.Compression;
using System.Security.Cryptography.X509Certificates;

public class Activity
{
    private string _name;
    private string _description;
    private int _duration;

    public Activity (string name, string description){
        _name = name;
        _description = description;
        }
    
    public void DisplayStartMessage(){
        Console.Clear();
        Console.WriteLine($"Welcome to the {_name}  Activity!");
        Console.WriteLine($"\n{_description}");
        Console.Write("\nHow long, in seconds, would you like for your session? ");
        _duration = int.Parse(Console.ReadLine());
    }
    public void DisplayEndMessage(){
        Console.WriteLine($"\nYou have completed another {_duration} seconds of the {_name} Activity.");
    }
    public int GetDuration(){
        return _duration;
    }
    public void DisplaySpinner(int spins){
        for(int i = 0; i < spins; i++){
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
    public void DisplayCountdown(int start){
        for (int i =start; i > 0; i--){
            Console.Write($"{i}");
            Thread.Sleep(1000);
            Console.Write("\b \b");
        }
    }
}