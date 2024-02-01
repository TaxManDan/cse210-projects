using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        Console.WriteLine("Welcome to the Journal Program!");
        while (myJournal._selector != 5)
        {
            myJournal.DisplayMenu();
        }
    }
}