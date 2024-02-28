using System;

class Program
{
    static void Main(string[] args)
    {
        int sel = 0;
        var breathe = new BreathingActivity();
        var reflect = new ReflectingActivity();
        var list = new ListingActivity();

        while (sel != 4)
        {

            Console.Clear();
            Console.Write(
                "Menu Options:"+
                "\n1. Start breathing activity"+
                "\n2. Start reflecting activity"+
                "\n3. Start listing activity"+
                "\n4. Quit"+
                "\nSelect a choice from the menu: ");
            sel = int.Parse(Console.ReadLine());

            switch (sel)
            {
                case 1:
                    breathe.DisplayStartMessage();
                    breathe.StartBreathing();
                    breathe.DisplayEndMessage();
                    break;
                case 2:
                    reflect.DisplayStartMessage();
                    reflect.StartReflecting();
                    reflect.DisplayEndMessage();
                    break;
                case 3:
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