using System.IO.Compression;

public class ReflectingActivity : Activity{
    
    private string _prompt;
    
    private string _question;
    private List<int> _questionIndex = new List<int>();
    private List<int> _promptIndex = new List<int>();

    private string[] _prompts = {"Think of a time when you stood up for someone else.",
        "Think of a time when you did something really difficult.",
        "Think of a time when you helped someone in need.",
        "Think of a time when you did something truly selfless."}; 
    
    private string[] _questions = {"Why was this experience meaningful to you?",
    "Have you ever done anything like this before?",
    "How did you get started?",
    "How did you feel when it was complete?",
    "What made this time different than other times when you were not as successful?",
    "What is your favorite thing about this experience?",
    "What could you learn from this experience that applies to other situations?",
    "What did you learn about yourself through this experience?",
    "How can you keep this experience in mind in the future?"};

    public ReflectingActivity() : base ("Reflecting", "This activity will help you reflect on times in your life when you have shown strength and resilience. This will help you recognize the power you have and how you can use it in other aspects of your life."){
               

    }

    public void StartReflecting(){
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.DisplaySpinner(5);
        GetPrompt();
        Console.WriteLine( 
            "Consider the following prompt:\n"+
            $"\n ---{_prompt}---\n"+
            "\nWhen you have something in mind, press enter to continue.");
        Console.ReadLine();
        Console.WriteLine("Now ponder on each of the following questions as they related to this experience.");
        Console.Write("\nYou may begin in: ");
        base.DisplayCountdown(3);
        Console.Clear();
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        while (startTime < futureTime){
            GetQuestion();
            Console.Write($"\n> {_question} ");
            base.DisplaySpinner(5);
            startTime = DateTime.Now;
        }
        Console.WriteLine("\n\nWell Done!!!");
        base.DisplaySpinner(3);
    }
    public void GetPrompt(){
        if (_promptIndex.Count ==0){
            for (int i = 0; i < _prompts.Length; i++){
            _promptIndex.Add(i);
        }
        }
        Random rand = new Random();
        int promptSelector = rand.Next(_promptIndex.Count);
        _prompt = _prompts[_promptIndex[promptSelector]];
        _promptIndex.Remove(_promptIndex[promptSelector]);
    }
    public void GetQuestion(){
        if (_questionIndex.Count ==0){
            for (int i = 0; i < _questions.Length; i++){
            _questionIndex.Add(i);
        }
        }
        int questionSelector = new Random().Next(_questionIndex.Count);
        _question = _questions[_questionIndex[questionSelector]];
        _questionIndex.Remove(_questionIndex[questionSelector]);
    }
   
}