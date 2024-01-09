using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("What Is your First Name?");
        string first = Console.ReadLine();
        Console.WriteLine("What Is your Last Name?");
        string last = Console.ReadLine();
        Console.WriteLine($"Your name is {last}, {first} {last}.");
    }
}