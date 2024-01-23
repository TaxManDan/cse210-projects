using System;

class Program
{
    static void Main(string[] args)
    {
        int menuInput = 0;
        Journal myJournal = new Journal();
        Entry entry = new Entry();
        while (menuInput != 5){
            myJournal.DisplayMenu();
            menuInput = int.Parse(Console.ReadLine());
            if (menuInput == 1){
                
                myJournal._entrys.Add(entry);
            }
            else if (menuInput == 2){

            }
            else if (menuInput == 3){

            }
            else if (menuInput == 4){

            }
            else {

            }
        }
    }
}