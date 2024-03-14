public class Item{
    private int _pointValue;
    private string _name;
    private int _quantityOwned;
    private int _shopQuantity;

    public string DisplayItem(){
        return $"{_name} {_shopQuantity} {_pointValue}";
    }
    
    public Item(string name, int pointValue,int quantity){
        _pointValue = pointValue;
        _name = name;
        _quantityOwned = 0;
        _shopQuantity = quantity;
    }
    public int GetCost(){
        return _pointValue;
    }
    public void BuyItem(){
        _quantityOwned += 1;
        _shopQuantity --;
    }
    public bool CheckInventory(){
        return _shopQuantity > 0;
    }
    public int GetQuantityOwned(){
        return _quantityOwned;
    }
    public void DisplayItemInventory(){
        Console.WriteLine($"Item:{_name} \nQuantity:{_quantityOwned}");
    }
    public void AddShopQuantity(){
        Console.Write($"How many {_name} would you like to add to shop? ");
        int amount = int.Parse(Console.ReadLine());
        _shopQuantity += amount;
    }
    public string GetName(){
        return _name;
    }
}