public class Bedroom : Room
{

    private int _beds;
    public Bedroom(string name, int beds) : base(name, "Bedroom")
    {
        _beds = beds;
    }

    public Bedroom(string name, List<Item> items, int beds) : base(name, "Bedroom", items){
        _beds = beds;
    }
    public override void DisplayRoom(){
        if (_beds >= 2){
        Console.WriteLine($"{_name} is a {_type} with {_beds} beds. ");
        }
        else {
            Console.WriteLine($"{_name} is a {_type} with {_beds} bed. ");
        }
    }

    public override string PrepareSave()
    {
        return base.PrepareSave()+",\""+_beds+"\"";
    }

}