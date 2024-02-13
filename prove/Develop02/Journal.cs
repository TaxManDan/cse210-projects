using System.Numerics;
using System.Security.Cryptography.X509Certificates;
using System.IO;

public class Journal
{
    public string _fileName;
    public List<Entry> _entries = new List<Entry>();
    public int _selector;
    PromptGenerator promptGenerator = new PromptGenerator();

    public void DisplayMenu()
    {
        // Dispay Menu options.
        Console.WriteLine("");
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
        // Get user input for menu selection.
        _selector = int.Parse(Console.ReadLine());
        Console.WriteLine();
        // Switch statement for menu options.
        switch (_selector)
        {
            case 1:
                WriteEntry();
                break;
            case 2:
                DisplayJournal();
                break;
            case 3:
                LoadJournal();
                break;
            case 4:
                SaveJournal();
                break;
            //
            case 5:
                Console.WriteLine("Journal Shutting down");
                Console.WriteLine();
                break;
            default:
                break;
        }

    }
    public void WriteEntry()
    {
        // Create new entry instance
        Entry entry = new Entry();

        // Generate and display prompt
        promptGenerator._prompt = promptGenerator.GeneratePrompt();
        Console.WriteLine($"{promptGenerator._prompt}");
        // Get current Date
        DateTime thecurrentTime = DateTime.Now;
        // Get user input for entry
        entry._entryText = Console.ReadLine();

        // Add entry to list of entries
        entry._entryPrompt = promptGenerator._prompt;
        entry._entryDate = thecurrentTime.ToShortDateString();
        _entries.Add(entry);
    }
    public void DisplayJournal()
    {
        // Go through list of entries and display each entry
        foreach (Entry entry in _entries)
        {
            Console.WriteLine(entry.CompileEntry());
        }
    }
    public void LoadJournal()
    {
        // Prompt for filename and read file
        Console.WriteLine("What is the Journal's Filename? (Enter filename without extension)");
        _fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{_fileName}.csv");
        // For each line, split parts and create new entry and add to journal
        foreach (string line in lines)
        {
            Entry loadEntry = new Entry();
            string[] parts = line.Split("\",\"");
            loadEntry._entryDate = parts[0].Trim('"');
            loadEntry._entryPrompt = parts[1];
            loadEntry._entryText = parts[2].TrimEnd('"');
            _entries.Add(loadEntry);
        }

    }
    public void SaveJournal()
    {
        // Prompt for filename
        Console.WriteLine("What do you want to make the Journal's Filename? (Enter filename without extension)");
        string _fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{_fileName}.csv"))
        {
            // Go through list of entries and add formatting compatible with csv files and save to file
            foreach (Entry entry in _entries)
            {
                outputFile.WriteLine($"\"{entry._entryDate}\",\"{entry._entryPrompt}\",\"{entry._entryText} \"");
            }
        }
    }

}