using System;

// To exceed the requirements I have added the ability to read from the scriptures.txt file so the user can put as many scriptures
// as they want so they can memorize multiple scriptures at once. Check  README.md for more details.

class Program
{
    static void Main(string[] args)
    {
        Scripture scripture1;
        Console.Clear();
        bool _shutdown = false;


        // Load the scriptures from the file.
        string[] lines = System.IO.File.ReadAllLines($"scriptures.txt");

        

        // Display the welcome message and ask if the user wants to select a scripture
        Console.WriteLine("Welcome to the Scripture Memorizer!");

        while (!_shutdown)
        {

        // Take all the Scriptures from the file and put them in a list of Scriptures
        List<Scripture> scriptures = new List<Scripture>();
        for (int i = 1; i < lines.Length; i++)
        {

            // Seperate the Scripture into reference and text
            string[] scriptureParts = lines[i].Split('|');
            string refer = scriptureParts[0].Trim();
            string text = scriptureParts[1].Trim();
            Scripture scripture = new Scripture(text, refer);
            scriptures.Add(scripture);
        }
            Console.Write("Do you want to select a scripture? (y/n) ");
            string sel = Console.ReadLine();

            // Check if the user wants to select a scripture
            if (sel == "y")
            {

                // Display the available scriptures and ask the user to select one
                Console.WriteLine("Here are the available scriptures:");
                for (int i = 0; i < scriptures.Count; i++)
                {
                    Console.WriteLine($"{i}. {scriptures[i].ShowReference()}");
                }
                Console.Write("Enter the number of the scripture you want to use: ");
                int num = int.Parse(Console.ReadLine());
                scripture1 = scriptures[num];
                Console.Clear();
            }
            else
            {

                // Randomly select a scripture if the user doesn't want to select one
                Random rand1 = new Random();
                int randomScripture = rand1.Next(0, scriptures.Count);
                scripture1 = scriptures[randomScripture];
                Console.Clear();
            }

            // Loop until the user wants to quit
            bool _quit = false;
            while (!_quit)
            {
                //Display the current Scripture state
                Console.WriteLine(scripture1.DisplayScripture());
                string input = Console.ReadLine();
                Console.Clear();

                // Check if the user wants to quit
                if (input == "quit")
                {
                    _quit = true;
                }
                else
                {

                    // Check if the scripture is hidden
                    _quit = scripture1.CheckHidden();
                    if (!_quit)
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
            Console.Write("Would you like to mermorize another Scripture? (y/n) ");
            string sel2 = Console.ReadLine();
            if (sel2 == "y")
            {
                _shutdown = false;
            }
            else
            {
                Console.WriteLine("Goodbye!");
                _shutdown = true;
            }
        }


    }
}
