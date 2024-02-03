using System;

class Program
{
    static void Main(string[] args)
    {
        // Create a new Journal instance.
        Journal myJournal = new Journal();

        // Display welcome message.
        Console.WriteLine("Welcome to the Journal Program!");
        
        // Start the Journal menu Loop.
        while (myJournal._selector != 5)
        {
            myJournal.DisplayMenu();
        }
    }
}