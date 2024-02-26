using System;

class Program
{
    static void Main(string[] args)
    {
        int sel = 0;

        while (sel != 4)
        {

            Console.Clear();
            Console.WriteLine("Menu Options:");
            Console.WriteLine("1. Start breathing activity");
            Console.WriteLine("2. Start reflecting activity");
            Console.WriteLine("3. Start listing activity");
            Console.WriteLine("4. Quit");
            Console.Write("Select a choice from the menu: ");
            sel = int.Parse(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    var breathe = new BreathingActivity();
                    breathe.DisplayStartMessage();
                    breathe.StartBreathing();
                    breathe.DisplayEndMessage();
                    break;
                case 2:
                    var reflect = new ReflectingActivity();
                    reflect.DisplayStartMessage();
                    reflect.StartReflecting();
                    reflect.DisplayEndMessage();
                    break;
                case 3:
                    var list = new ListingActivity();
                    list.DisplayStartMessage();
                    list.StartListing();
                    list.DisplayEndMessage();
                    break;
                default:
                    break;


            }



        }
    }
}