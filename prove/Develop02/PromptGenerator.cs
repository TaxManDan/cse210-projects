public class PromptGenerator{
    public string _prompt;
    string[] prompts = {"If I had one thing I could do over today, what would it be?"};
    public string GeneratePrompt(){
        Random rand = new Random();
        int promptSelector = rand.Next(prompts.Length); 
        _prompt = prompts[promptSelector];
        return _prompt;
    }
}