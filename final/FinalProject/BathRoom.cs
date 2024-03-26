public class Bathroom : Room
{
private bool _fullBath;
private int _sinks;

    public Bathroom(string name,  bool fullBath, int sinks, List<Item> items) : base(name, "Bathroom", items)
    {
        _fullBath = fullBath;
        _sinks = sinks;
    }
    public Bathroom(string name, bool fullBath, int sinks) : base(name, "Bathroom"){
        _fullBath = fullBath;
        _sinks = sinks;
    }

    public override void DisplayRoom(){
        if (_fullBath){
            Console.WriteLine($"{_name} is a full {_type} with {_sinks} sinks.");
        }
        else{
        Console.WriteLine($"{_name} is a half {_type} with {_sinks} sinks.");
        }
    }
    public override string PrepareSave(){
        return base.PrepareSave()+",\""+_fullBath+"\",\""+_sinks+"\"";
    }
}