using System;
using System.ComponentModel.Design;

class Program
{
    static void Main(string[] args)
    {
        List<Room> rooms = new List<Room>();
        int sel = 0;
        while (sel !=9){
            Console.Clear();
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

                    break;
                case 2:

                    break;
                case 3:
                    foreach (Room room in rooms){
                        room.DisplayRoom();
                    }
                    break;
                case 4:
                    
                    break;
                case 5:
                    break;
                case 6:
                    break;
                case 7:
                    break;
                case 8:
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