using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
         Random rand1   = new Random();
        string[] lines = System.IO.File.ReadAllLines($"scriptures.txt");
        int randomScripture = rand1.Next(0, lines.Length);
        string[] scriptureParts = lines[randomScripture].Split('|');
        string refer1 = scriptureParts[0].Trim();
        string text1 = scriptureParts[1].Trim();
        Scripture scripture1 = new Scripture(text1, refer1);
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine(scripture1.DisplayScripture());
            string input = Console.ReadLine();
            Console.Clear();
            if (input == "quit")
            {
                quit = true;
            }
            else
            {
                quit = scripture1.CheckHidden();
                if (!quit)
                {
                    scripture1.HideScripture();
                }
                else
                {
                    Console.WriteLine("The scripture is hidden.");
                }
            }
        }





    }
}
