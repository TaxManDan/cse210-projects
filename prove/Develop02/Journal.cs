using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal{
    public string _fileName;
    public List<Entry>_entries = new List<Entry>();
    public int _selector;
    PromptGenerator promptGenerator = new PromptGenerator();
    
    public void DisplayMenu(){
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
        _selector = int.Parse(Console.ReadLine());
        if (_selector == 1){
            WriteEntry();
        }
        else if (_selector == 2){
            DisplayJournal();
        }
        else if (_selector == 3){
            LoadJournal();
        }
        else if (_selector == 4){
            SaveJournal();
        }
        else{

        }
    }
    public void WriteEntry(){
        Entry entry = new Entry();
        promptGenerator._prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine($"{promptGenerator._prompt}");
        DateTime thecurrentTime = DateTime.Now;
        entry._entryText = Console.ReadLine();
        entry._entryPrompt = promptGenerator._prompt;
        entry._entryDate = thecurrentTime.ToShortDateString();
        _entries.Add(entry);
    }
    public void DisplayJournal(){
        foreach (Entry entry in _entries){
            Console.WriteLine(entry.CompileEntry());
        }
    }
    public void LoadJournal(){
        
    }
    public void SaveJournal(){
        Console.WriteLine("");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter(_fileName)){
            
        }
    }

}