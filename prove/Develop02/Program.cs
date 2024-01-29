using System;

class Program
{
    static void Main(string[] args)
    {
        Journal myJournal = new Journal();
        while (myJournal._selector != 5){
            myJournal.DisplayMenu();
        }
    }
}