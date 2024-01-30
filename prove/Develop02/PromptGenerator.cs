public class PromptGenerator{
    public string _prompt;
    
    // Array of prompts for Journal to be randomly picked.
    string[] prompts = {"If I had one thing I could do over today, what would it be?", "Three good things: Start your day with gratitude by listing three things you're grateful for, big or small.", "Something I learned: Reflect on any new insights or lessons you gained from today's experiences."};

    // Using length of prompt array to pick a random index and return the cooresponding prompt.
    public string GeneratePrompt(){
        Random rand = new Random();
        int promptSelector = rand.Next(prompts.Length); 
        _prompt = prompts[promptSelector];
        return _prompt;
    }
}