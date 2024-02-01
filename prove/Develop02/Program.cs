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
            switch (myJournal._selector)
            {
                case 1:
                    myJournal.WriteEntry();
                    break;
                case 2:
                    myJournal.DisplayJournal();
                    break;
                case 3:
                    myJournal.LoadJournal();
                    break;
                case 4:
                    myJournal.SaveJournal();
                    break;
                case 5:
                    Console.WriteLine("Journal Shutting down");
                    Console.WriteLine();
                    break;
                default:
                    break;
            }
        }
    }
}