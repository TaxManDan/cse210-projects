public class ListingActivity : Activity {
    private int _count;
    private string _prompt;
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
    };
    private List<int> _promptIndex = new List<int>();

    public ListingActivity() : base("Listing", "This activity will help you reflect on the good things in your life by having you list as many things as you can in a certain area."){

    }
    public void StartListing(){
        _count = 0;
        Console.Clear();
        Console.WriteLine("Get Ready...");
        base.DisplaySpinner(5);
        Console.WriteLine("List as many responses as you can to the following prompt:");
        GetPrompt();
        Console.WriteLine($"\n---{_prompt}---");
        Console.Write("You may begin in: ");
        base.DisplayCountdown(5);
        Console.WriteLine("");
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());
        while (startTime < futureTime){
            Console.Write($"> ");
            Console.ReadLine();
            _count++;
            startTime = DateTime.Now;
        }
        Console.WriteLine($"\nYou listed {_count} items!");

        Console.WriteLine("\nWell Done!!");
        base.DisplaySpinner(5);
    }

    public void GetPrompt(){
        if (_promptIndex.Count == 0){
            for (int i = 0; i < _prompts.Length; i++){
                _promptIndex.Add(i);
            }
            Random rand1 = new Random();
            int propmtSelector = rand1.Next(_promptIndex.Count);
            _prompt = _prompts[_promptIndex[propmtSelector]];
            _promptIndex.Remove(_promptIndex[propmtSelector]);
        }
    }
}