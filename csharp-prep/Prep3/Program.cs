using System;

class Program
{
    static void Main(string[] args)
    {
        string play = "yes";
        while (play == "yes"){

        
        Random randomGenerator = new Random();
        int m_num = randomGenerator.Next(1,101);    
        int guess = -4;
        int guess_count = 0;
        while ( guess != m_num){
            Console.Write("What is your guess? ");
            guess = int.Parse(Console.ReadLine());
            if (guess > m_num){
                Console.WriteLine("Lower");
            }
            else if (guess < m_num){
                Console.WriteLine("Higher");
            }
            else {
                Console.WriteLine("You guessed it! ");
            }
            guess_count += 1;
        }
        Console.WriteLine($"You got it in {guess_count} guesses. ");
        Console.Write("Would you like to play again? 'yes' or 'no'");
        play = Console.ReadLine();
        }
    }
}