using System;
using System.Globalization;

class Program
{
    static void Main(string[] args)
    {
        DisplayMessage();
        string user_name = PromptUserName();
        int user_number = PromptUserNumber();
        int square_num = SquareNumber(user_number);
        DisplayResult(user_name, square_num);

    }
    static void DisplayMessage(){
        Console.WriteLine("Welcome to the Program!");
    }
    static string PromptUserName(){
    Console.Write("Please enter your name: ");
    string name = Console.ReadLine();
    return name;
    }
    static int PromptUserNumber(){
        Console.Write("Please enter your favorite number: ");
        int num = int.Parse(Console.ReadLine());
        return num;    
    }
    static int SquareNumber(int num){
        int square_number = num * num;
        return square_number;
    }
    static void DisplayResult(string name, int num){
        Console.WriteLine($"{name}, the square of your number is {num}");
    }
    
}