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
                string name = room.GetName();

                foreach (Item item in items){
                    outputFile.WriteLine("\"" + name + "\"," + item.PrepareSave());
                }
            }
        }
    }
    public void LoadRooms(){
        Console.Write("What is the filename? (excluding file extension): ");
        string fileName = Console.ReadLine();
        Rooms = new List<Room>();
        string roomName = null;
        int sinks;
        int RoomIndex = -1;
        string[] lines = System.IO.File.ReadAllLines($"{fileName}.csv");
        foreach (string line in lines){
            string[] parts = line.Split("\",\"");
            string firstPart = parts[0].Trim('"');

            if (firstPart == "Bathroom"){
                RoomIndex ++;
                roomName = parts[1];
                bool fullBath = bool.Parse(parts[2]);
                sinks = int.Parse(parts[3].Trim('"'));
                Rooms.Add(new Bathroom(roomName, fullBath, sinks));

            }
            else if (firstPart == "Bedroom"){
                RoomIndex ++;
                roomName = parts[1];
                int beds = int.Parse(parts[2].Trim('"'));
                Rooms.Add(new Bedroom(roomName, beds));
            }
            else if (firstPart == "Kitchen"){
                RoomIndex ++;
                roomName = parts[1];
                sinks = int.Parse(parts[2].Trim('"'));
                Rooms.Add(new Kitchen(roomName, sinks));
            }
            else if (firstPart == "Misc"){
                RoomIndex ++;
                roomName = parts[1].Trim('"');
                Rooms.Add(new Room(roomName,"Misc"));
            }
            else if (firstPart == roomName){
                Item item = null;
                string itemName = parts[2];
                string itemDescription = parts[3];
                string itemColor = parts[4];
                int itemValue = int.Parse(parts[5].Trim('"'));
            
                if (parts[1] == "Electronic"){
                    string itemBrand = parts[6];
                    string itemModel = parts[7];
                    string itemSerial = parts[8].Trim('"');
                    item = new ElectronicItem(itemBrand, itemModel, itemSerial, itemName, itemDescription, itemColor, itemValue);
                }
                else if (parts[1] == "Furniture"){
                    string itemMaterial = parts[6].Trim('"');
                    item = new FurnitureItem(itemName, itemDescription,itemColor, itemValue, itemMaterial);
                }
                else if (parts[1]== "Misc"){
                    item = new Item(itemName, "Misc",itemColor, itemDescription, itemValue);
                }
                Rooms[RoomIndex].ImportItem(item);
            }
        }
    }
}