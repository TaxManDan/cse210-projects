using System;

class Program
{
    static void Main(string[] args)
    {
        Console.Clear();
        string text1 = "For God so loved the world that he gave his one and only Son, that whoever believes in him should not perish but have eternal life.";
        string refer1 = "John 3:16";
        Scripture scripture1 = new Scripture(text1,refer1);
        bool quit = false;
        while (!quit){
            Console.WriteLine(scripture1.DisplayScripture());
            string input =Console.ReadLine();
            Console.Clear();
            if (input == "quit"){
                quit = true;
            }
            else{
                quit = scripture1.CheckHidden();
                if (!quit){
                    scripture1.HideScripture();
                }
                else{
                    Console.WriteLine("The scripture is hidden.");
                }
            }
        }

       
        
        

    }
}
