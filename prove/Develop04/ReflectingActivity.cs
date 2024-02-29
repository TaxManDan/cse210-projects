using System.IO.Compression;

public class ReflectingActivity : Activity
{

    private string _prompt;

    private string _question;
    private List<int> _questionIndex = new List<int>();
    private List<int> _promptIndex = new List<int>();

    private string[] _prompts = {
        "Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless.",
        "Think of a time when you took a risk.",
        "Think of a time when you learned something new.",
        "Think of a time when you changed your ways.",
        };

    private string[] _questions = {
    "Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How has this experience changed your life?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "Are there any regrets that you have from it?",
    "Why did you think about this experience?",
    "What were some of the causes of this experience?",
    "Is there anything you would like to change about this experience?"
    };

    // Pass the Activity name and Description to the parent class
    public ReflectingActivity() : base("Reflecting", "This activity will help you reflect on times in your " +
    "life when you have shown strength and resilience. This will help you recognize the power you have and " +
    "how you can use it in other aspects of your life.")
    {

    }

    public void StartReflecting()
    {
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.DisplaySpinner(5);

        // Get prompt and display the prompt for the user to reflect on
        GetPrompt();
        Console.WriteLine(
            "Consider the following prompt:\n" +
            $"\n ---{_prompt}---\n" +
            "\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in: ");
        base.DisplayCountdown(3);
        Console.Clear();

        // Add the duration of the activity to the current time to find the end time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());

        // Get questions and display the questions for the user to reflect on until the time is up
        while (startTime < futureTime)
        {
            GetQuestion();
            Console.Write($"\n> {_question} ");
            base.DisplaySpinner(5);
            startTime = DateTime.Now;
        }
        Console.WriteLine("\n\nWell Done!!!");
        base.DisplaySpinner(3);
    }
    public void GetPrompt()
    {

        // Check if there are prompts left in the index
        if (_promptIndex.Count == 0)
        {
            // If there are no prompts left in the index, add them all to the index
            for (int i = 0; i < _prompts.Length; i++)
            {
                _promptIndex.Add(i);
            }
        }
        Random rand = new Random();
        // Select a random prompt from the index and then remove it from the index
        int promptSelector = rand.Next(_promptIndex.Count);
        _prompt = _prompts[_promptIndex[promptSelector]];
        _promptIndex.Remove(_promptIndex[promptSelector]);
    }
    public void GetQuestion()
    {

        // Check if there are questions left in the index
        if (_questionIndex.Count == 0)
        {
            // If there are no questions left in the index, add them all to the index
            for (int i = 0; i < _questions.Length; i++)
            {
                _questionIndex.Add(i);
            }
        }

        // Select a random question from the index and then remove it from the index
        int questionSelector = new Random().Next(_questionIndex.Count);
        _question = _questions[_questionIndex[questionSelector]];
        _questionIndex.Remove(_questionIndex[questionSelector]);
    }
}