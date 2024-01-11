using System;
using System.Globalization;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<int> number = new List<int>();
        Console.WriteLine("Enter a list of number, type 0 when Finished.");
        int num = 10000;
        while (num != 0){
            Console.Write("Enter number: ");
            num = int.Parse(Console.ReadLine());
            if (num != 0){
                number.Add(num);
            }
            else {}
        }
        int sum = 0;
        int max = number[0];
        for (int i = 0; i < number.Count; i++){
            sum += number[i];
            if (max < number[i]){
                max = number[i];
            }
            else{

            }
        }
        float average = ((float)sum) / number.Count;
        Console.WriteLine($"The sum is: {sum}");
        Console.WriteLine($"The average is: {average}");
        Console.WriteLine($"The largest number is: {max}");
    }
}