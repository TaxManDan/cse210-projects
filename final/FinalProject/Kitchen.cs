public class Kitchen : Room{
    private int _sinks;

    public Kitchen(string name, int sinks): base(name,"Kitchen"){
        _sinks = sinks;
    }
    public Kitchen(string name, int sinks, List<Item> items) : base(name, "Kitchen", items){
        _sinks = sinks;
    }
    public override void DisplayRoom()
    {
        Console.WriteLine($"{_name} is {_type} with {_sinks} sinks.");
    }

    public override string PrepareSave(){
        return base.PrepareSave() + ",\"" + _sinks + "\"";
    }

}