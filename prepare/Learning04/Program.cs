using System;

class Program
{
    static void Main(string[] args)
    {
        string name1 = "Samuel Bennett";
        string topic1 = "Multiplication";
        var student1 = new Assignment(name1, topic1);
        Console.WriteLine(student1.GetSummary());
        string name2 = "Roberto Rodriguez";
        string topic2 = "Fractions";
        string textbookSection1 = "Section 7.3";
        string problems1 = "8-19";
        var student2 = new MathAssignment(name2, topic2, textbookSection1, problems1);
        Console.WriteLine(student2.GetHomeworkList());
        string name3 = "Mary Waters";
        string topic3 = "European History";
        string title1 = "The Causes of World War II";
        var student3 = new WritingAssignment(name3, topic3, title1);
        Console.WriteLine(student3.GetWritingInformation());
    }
}