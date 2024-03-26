using System.Runtime.InteropServices;

public class File{
    
    public List<Room> Rooms { get; set; }

    public void SaveRooms(){
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{fileName}.csv"))
        {
            foreach (Room room in Rooms){
                outputFile.WriteLine(room.PrepareSave());
                List<Item> items = room.GetItems();

                foreach (Item item in items){
                    outputFile.WriteLine(item.PrepareSave());
                }
            }
        }
    }
    public void LoadRooms(){
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.csv");
        foreach (string line in lines){
            string[] parts = line.Split("\",\"");
            if (parts[0] == "Bathroom"){
                
            }
        }
    }
}