using System;

class Program
{
    static void Main(string[] args)
    {
        string test = "Nephi";
        int chap = 3;
        int ver = 5;
        int ber = 8;
        Reference refer = new Reference(test, chap, ver, ber);
        
        Console.WriteLine(refer.DisplayReference());

    }
}