using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal{
    public string _fileName;
    public List<Entry>_entries = new List<Entry>();
    public int _selector;
    PromptGenerator promptGenerator = new PromptGenerator();
    
    public void DisplayMenu(){
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
        _selector = int.Parse(Console.ReadLine());
        Console.WriteLine();
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
        Console.WriteLine("What is the Journal's Filename? ");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{_fileName}.csv");
        foreach (string line in lines){
            Entry loadEntry = new Entry();
            string[] parts = line.Split("\",\"");
            loadEntry._entryDate = parts[0].Trim('"');
            loadEntry._entryPrompt = parts[1];
            loadEntry._entryText = parts[2].TrimEnd('"');
            _entries.Add(loadEntry);
        }

    }
    public void SaveJournal(){
        Console.WriteLine("What do you want to make the Journal's Filename? ");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{_fileName}.csv")){
            foreach (Entry entry in _entries){
                outputFile.WriteLine($"\"{entry._entryDate}\",\"{entry._entryPrompt}\",\"{entry._entryText} \"");
            }
        }
    }

}