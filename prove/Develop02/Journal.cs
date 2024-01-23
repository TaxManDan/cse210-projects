public class Journal{
    public string _fileName;
    public List<Entry>_entrys = new List<Entry>();

    public void DisplayMenu(){
        Console.WriteLine("Please select one of the following options: ");
        Console.WriteLine("1: Write");
        Console.WriteLine("2: Display");
        Console.WriteLine("3: Load");
        Console.WriteLine("4: Save");
        Console.WriteLine("5: Quit");
    }
    public void DisplayJournal(){
        foreach (Entry entry in _entrys){
            Console.WriteLine($"{entry.MergeEntry}");
        }
    }
}