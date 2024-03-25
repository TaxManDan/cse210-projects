public class Item{
    protected string _name;
    protected string _type;
    protected string _color;
    protected string _description;
    protected int _price;


    public Item(string name, string type, string color, string description, int price){
        _name = name;
        _type = type;
        _color = color;
        _description = description;
        _price = price;
    }
    public virtual string DisplayItem(){
        return _name;
    }
    public virtual string PrepareSave(){
        return $"\"{_type}\",\"{_name}\",\"{_color}\",\"{_description}\",\"{_price}\"";
    } 
    public int GetPrice(){
        return _price;
    }
}