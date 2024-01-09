using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What is your Grade Percentage?");
        int gp = int.Parse(Console.ReadLine());
        char letter;
        if (gp >= 90){
            letter = 'A';
        }
        else if (gp >= 80){
           letter = 'B';
        }
        else if (gp >= 70){
            letter = 'C';
        }
        else if (gp >= 60){
            letter = 'D';
        }
        else {
            letter = 'F';
        }
        Console.WriteLine($"You received the grade letter: {letter}.");
        if (gp >= 70){
            Console.WriteLine("Congrats on passing the class!");
        }
        else {
            Console.WriteLine("Try again Next time.");
        }
    }
}