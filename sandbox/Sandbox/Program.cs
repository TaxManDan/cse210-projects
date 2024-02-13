using System;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello Sandbox World!");
        string word = "Hello";
        Console.WriteLine($"{HideWord(word)}");
        Console.WriteLine(word);
        string HideWord(string _word){
        string hiddenWord = "";
        for (int i = 0; i < _word.Length; i++){
            hiddenWord += "_";
        }
        return hiddenWord;
    }
    }
}