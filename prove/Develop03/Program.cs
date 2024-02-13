using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
         Random rand1   = new Random();
         // Load the scriptures from the file.
        string[] lines = System.IO.File.ReadAllLines($"scriptures.txt");
        // Pick a random scripture not including the instructions
        int randomScripture = rand1.Next(1, lines.Length);

        // Seperate the Scripture into reference and text
        string[] scriptureParts = lines[randomScripture].Split('|');
        string refer1 = scriptureParts[0].Trim();
        string text1 = scriptureParts[1].Trim();
        // Create the new scripture instance using the constructor
        Scripture scripture1 = new Scripture(text1, refer1);
        bool quit = false;
        while (!quit)
        {
            Console.WriteLine(scripture1.DisplayScripture());
            string input = Console.ReadLine();
            Console.Clear();

            // Check if the user wants to quit
            if (input == "quit")
            {
                quit = true;
            }
            else
            {
                // Check if the scripture is hidden
                quit = scripture1.CheckHidden();
                if (!quit)
                {
                    // Hide words in the scripture
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
