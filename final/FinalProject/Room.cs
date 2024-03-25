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
            item.DisplayItem();
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
}