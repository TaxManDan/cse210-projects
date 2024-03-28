using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();
        File file = new File();
        int sel = 0;
        string roomName = null;
        Console.Clear();
        int sinks ;
        while (sel !=9){
            Console.Write("House Inventory Options: "+
            "\n1. Add Room"+
            "\n2. Add Item"+
            "\n3. Display Rooms"+
            "\n4. Display Items"+
            "\n5. Save Rooms"+
            "\n6. Load Rooms"+
            "\n7. View Room Total Value"+
            "\n8. View Total Value"+
            "\n9. Exit"+
            "\nSelect an option: ");
            sel = int.Parse(Console.ReadLine());
            switch(sel){
                case 1:
                    Console.WriteLine("Which type of room would you like to add?"+
                    "\n1. Bedroom"+
                    "\n2.Bathroom"+
                    "\n3. Kitchen"+
                    "\n4. Misc");
                    int roomType = int.Parse(Console.ReadLine());
                    switch (roomType){
                        case 1:
                            Console.Write("What is the name of the room? ");
                            roomName = Console.ReadLine();
                            Console.Write("How many beds are in the room? ");
                            int beds = int.Parse(Console.ReadLine());
                            rooms.Add(new Bedroom(roomName, beds));
                            break;
                        case 2:
                        Console.Write("What is the name of the room? ");
                            roomName = Console.ReadLine();
                            Console.Write("How many sinks are in the room? ");
                            sinks = int.Parse(Console.ReadLine());
                            Console.Write("Is it a full bathroom?(y/n) ");
                            string fullBath = Console.ReadLine();
                            if (fullBath == "y"){
                                rooms.Add(new Bathroom(roomName, true, sinks));
                            }
                            else{
                                rooms.Add(new Bathroom(roomName, false, sinks));
                            }
                            break;
                        case 3:
                            Console.Write("What is the name of the room? ");
                            roomName = Console.ReadLine();
                            Console.Write("How many sinks are in the room? ");
                            sinks = int.Parse(Console.ReadLine());
                            rooms.Add(new Kitchen(roomName, sinks));
                            break;

                        case 4:
                            Console.Write("What is the name of the room? ");
                            roomName = Console.ReadLine();
                            rooms.Add(new Room(roomName, "Misc"));
                            break;
                        default:
                            Console.WriteLine("Invalid Selection");
                            break;
                    }
                    break;
                case 2:
                    int index = 1;
                    Console.WriteLine("Which room would you like to add an item to?");
                    foreach (Room room in rooms){
                    Console.WriteLine(index + ". " +room.ListRooms());
                    index++;
                    }
                    Console.Write("Enter room number: ");
                    int roomSel = int.Parse(Console.ReadLine());
                    rooms[roomSel-1].AddItem();
                    break;
                case 3:
                    foreach (Room room in rooms){
                        room.DisplayRoom();
                    }
                    break;
                case 4:
                    int roomIndex = 1;
                    Console.WriteLine("Which room would you like to view items of? ");
                    foreach (Room room in rooms){
                    Console.WriteLine(roomIndex + ". " +room.ListRooms());
                    roomIndex++;
                    }
                    Console.Write("Enter room number: ");
                    int roomNum = int.Parse(Console.ReadLine());
                    rooms[roomNum-1].DisplayItems();
                    break;
                case 5:
                    file.Rooms = rooms;
                    file.SaveRooms();   
                    break;
                case 6:
                    file.LoadRooms();
                    rooms = file.Rooms;
                    break;
                case 7:
                    int valueIndex = 1;
                    Console.WriteLine("Which room would you like to view total value?");
                    foreach (Room room in rooms){
                    Console.WriteLine(valueIndex + ". " +room.ListRooms());
                    valueIndex++;
                    }
                    Console.Write("Enter room number: ");
                    int valueSel = int.Parse(Console.ReadLine());
                    Console.WriteLine("Total Value: $"+rooms[valueSel-1].CaculateTotal());
                    break;
                case 8:
                    int houseTotal = 0;
                    foreach (Room room in rooms){
                       houseTotal += room.CaculateTotal();
                    }
                    Console.WriteLine("Total House Item Value: $"+houseTotal);
                    break;
                case 9:
                    Console.WriteLine("Goodbye!");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    break;
            }
        }


       
    }
}