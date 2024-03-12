public class Item{
    private int _pointValue;
    private int _name;

    public string DisplayItem(){
        return $"{_name}   {_pointValue}";
    }
}