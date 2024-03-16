public class Item
{
    private int _pointValue;
    private string _name;
    private int _quantityOwned;
    private int _shopQuantity;


    // Constructors for both creating items or loading items from a file
    public Item(string name, int pointValue, int quantity)
    {
        _pointValue = pointValue;
        _name = name;
        _quantityOwned = 0;
        _shopQuantity = quantity;
    }
    public Item(string name, int cost, int shopQuantity, int inventory)
    {
        _name = name;
        _pointValue = cost;
        _shopQuantity = shopQuantity;
        _quantityOwned = inventory;
    }

    // Displays the item name, cost, and shop quantity
    public string DisplayItem()
    {
        return $"Item: {_name} Quantity: {_shopQuantity} Price: {_pointValue}";
    }


    // Adds one to the inventory and takes one from the shop.
    public void BuyItem()
    {
        _quantityOwned += 1;
        _shopQuantity--;
    }

    // Check if the item is in the shop.
    public bool CheckInventory()
    {
        return _shopQuantity > 0;
    }


    //Displays the Item name and quantity of items in users inventory.
    public void DisplayItemInventory()
    {
        Console.WriteLine($"Item:{_name} \nQuantity:{_quantityOwned}");
    }

    // Allows the user to increase the quantity of an item in the shop.
    public void AddShopQuantity()
    {
        Console.Write($"How many {_name} would you like to add to shop? ");
        int amount = int.Parse(Console.ReadLine());
        _shopQuantity += amount;
    }

    // Saves the item details as a string.
    public string PrepareSave()
    {
        return "Item" + ":" + _name + "," + _pointValue + "," + _quantityOwned + "," + _shopQuantity;
    }

    //Uses an item and removes one from the inventory
    public void UseItem()
    {
        _quantityOwned -= 1;
    }

    // Getters
    public int GetQuantityOwned()
    {
        return _quantityOwned;
    }
    public int GetCost()
    {
        return _pointValue;
    }

    public string GetName()
    {
        return _name;
    }

    public int GetShopQuantity()
    {
        return _shopQuantity;
    }
}