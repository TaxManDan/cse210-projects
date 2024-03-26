using System.Net.Http.Headers;

public class Room
{
    protected string _name;
    protected string _type;
    protected List<Item> _items = new List<Item>();

    public Room(string name, string type)
    {
        _name = name;
        _type = type;
    }

    public Room(string name, string type, List<Item> items){
        _name = name;
        _type = type;
        _items = items;
    }
    public void DisplayItems(){
        foreach (Item item in _items){
            Console.WriteLine(item.DisplayItem());
        }
    }
    public virtual string PrepareSave(){
        return $"{_name},{_type}";
    }
    public virtual void DisplayRoom(){
        Console.WriteLine($"{_name} is {_type}");
    }
    public List<Item> GetItems(){
        return _items;
    }
    public int CaculateTotal(){
        int total = 0;
        foreach (Item item in _items){
            total += item.GetPrice();
        }

        return total;
    }
    public void AddItem(){
        Console.WriteLine("What is the type of the item? \n1.Electronic \n2.Furniture \n3.Misc)");
        int type =int.Parse(Console.ReadLine());
        if (type == 1){
            Console.Write("What is the name of the item? ");
            string name = Console.ReadLine();
            Console.Write("What is the description of the item? ");
            string description = Console.ReadLine();
            Console.Write("What is the color of the item? ");
            string color = Console.ReadLine();
            Console.Write("What is the value of the item? ");
            int value = int.Parse(Console.ReadLine());
            Console.Write("What is the brand of the item? ");
            string brand = Console.ReadLine();
            Console.Write("What is the model of the item? ");
            string model = Console.ReadLine();
            Console.Write("What is the serial number of the item? ");
            string serial = Console.ReadLine();
            _items.Add(new ElectronicItem(brand, model, serial, name, description, color, value));
        }
        else if (type == 2){

        }
        
    }
}