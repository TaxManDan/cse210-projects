public class ListingActivity : Activity
{
    private int _count;
    private string _prompt;
    private string[] _prompts = {
        "Who are people that you appreciate?",
        "What are personal strengths of yours?",
        "what are you grateful for?",
        "Where are places you want to visit?",
        "What are some of your excuses when you are late?",
        "What are some skills you want to learn?",
        "What are some memories that bring you joy?"
    };
    private List<int> _promptIndex = new List<int>();

    // Pass the Activity name and description to the parent class
    public ListingActivity() : base("Listing", "This activity will help you reflect on " +
    "the good things in your life by having you list as many things as you can in a certain area.")
    {

    }
    public void StartListing()
    {
        // Reset the counter
        _count = 0;
        Console.Clear();
        Console.WriteLine("Get Ready...");

        // Get a random prompt and display it
        GetPrompt();
        base.DisplaySpinner(3);
        Console.Write(
            "\nList as many responses as you can to the following prompt:\n" +
            $"\n---{_prompt}---\n" +
            "\nYou may begin in: ");
        base.DisplayCountdown(5);
        Console.WriteLine("");

        //Add Duration onto current time to get future time
        DateTime startTime = DateTime.Now;
        DateTime futureTime = startTime.AddSeconds(base.GetDuration());

        // Count users responses until they reach the duration
        while (startTime < futureTime)
        {
            Console.Write($"> ");
            Console.ReadLine();
            _count++;
            startTime = DateTime.Now;
        }

        // Display number of responses
        Console.WriteLine($"\nYou listed {_count} items!");

        Console.WriteLine("\n\nWell Done!!!");
        base.DisplaySpinner(3);
    }

    public void GetPrompt()
    {

        // Check if the prompt index is empty
        if (_promptIndex.Count == 0)
        {

            // If the prompt index is empty, add all prompts to the index
            for (int i = 0; i < _prompts.Length; i++)
            {
                _promptIndex.Add(i);
            }
        }

        // Get a random prompt from the index and remove it from the index
        Random rand1 = new Random();
        int propmtSelector = rand1.Next(_promptIndex.Count);
        _prompt = _prompts[_promptIndex[propmtSelector]];
        _promptIndex.Remove(_promptIndex[propmtSelector]);
    }

}