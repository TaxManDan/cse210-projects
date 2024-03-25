using System.Runtime.InteropServices;

public class File{
    
    public List<Room> Rooms { get; set; }

    public void SaveRooms(){
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        using (StreamWriter outputFile = new StreamWriter($"{fileName}.txt"))
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
}