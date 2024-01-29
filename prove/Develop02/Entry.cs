public class Entry{
    public string _entryPrompt;
    public string _entryDate;
    
    public string _entryText;

    public string CompileEntry(){
        string _entry = $"Date: {_entryDate} Prompt: {_entryPrompt} Response: {_entryText}";
        return _entry;
    }
        
}