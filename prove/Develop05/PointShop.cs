using Microsoft.VisualBasic;

public class PointShop{
    
    private int _score;
    private List<int> inventoryIndex = new List<int>();
    
    private List<Item> _items = new List<Item>();
    public void AddItem(){
        Console.Write("What is the name of the item? ");
        string name = Console.ReadLine();
        Console.Write("What is the cost of the item? ");
        int cost = int.Parse(Console.ReadLine());
        Console.Write("What quantity of the item would you like to add? ");
        int quantity = int.Parse(Console.ReadLine());
        Item newItem = new Item(name, cost, quantity);
        _items.Add(newItem);
    }
    public void SetScore(int score){
        _score = score;
    }
    public void DisplayShop(){
        Console.WriteLine("Point Shop");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine("List of Items: ");
        int itemIndex = 1;
        foreach (Item item in _items){
            Console.WriteLine($"{itemIndex}. {item.DisplayItem()}");
            itemIndex ++;
        }        
        
    }

    public void SetItems(List<Item> items){
        _items = items;
    }
    public List<Item> GetItems(){
        return _items;
    }
    public void DisplayShopMenu(){
        var file = new File();
        int shopSelection = 0;
        while (shopSelection != 7) {    
        Console.Write(
                "\nReward Shop Menu Options:"+
                "\n1. Add New Shop Items"+
                "\n2. List Shop Items"+
                "\n3. Purchase Item"+
                "\n4. List Inventory"+
                "\n5. Adjust Shop Quantities"+
                "\n6. Redeem Item"+
                "\n7. Return to Main Menu"+
                "\nSelect a choice from the menu: ");
                shopSelection = int.Parse(Console.ReadLine());
                switch (shopSelection){
                    case 1:
                        AddItem();
                        break;
                    case 2:
                        DisplayShop();
                        break;
                    case 3: 
                        BuyItem();
                        break;
                    case 4:
                        DisplayInventory();
                        break;
                    case 5:
                        IncreaseQuantity();
                        break;
                    case 6:
                        RedeemItem();
                        break;
                    case 7:
                        Console.WriteLine("Returning to main menu. ");
                        break;
                    default:
                        Console.WriteLine("Invalid selection. ");
                        break;
                }
        }
    }
    public void BuyItem(){
        DisplaySelection();
        Console.Write("Which item would you like to buy? (enter the number) ");
        int itemSelection = int.Parse(Console.ReadLine());
       if (_items[itemSelection - 1].GetCost() > _score){
           Console.WriteLine("You don't have enough points. Try again. ");
       }
        else {
        _score -= _items[itemSelection - 1].GetCost();
        _items[itemSelection - 1].BuyItem();
        Console.WriteLine($"Thank you for your purchase of {_items[itemSelection - 1].GetName()}");
        Console.WriteLine($"You now have {_score} points. ");

        }
    }
    public void DisplayInventory(){
        foreach (Item item in _items){
            if (item.GetQuantityOwned() > 0){
                item.DisplayItemInventory();
            }
        }
    }
    public void RedeemItem(){
        int itemIndex = 0;
        foreach (Item item in _items){
            if (item.GetQuantityOwned() > 0){
                Console.WriteLine($"{inventoryIndex.Count + 1}. {item.GetName()}");
                inventoryIndex.Add(itemIndex);
            }
            itemIndex ++;
        }
        Console.Write("Which item would you like to redeem? (enter the number) ");
        int redeemSelection = int.Parse(Console.ReadLine());
        _items[inventoryIndex[redeemSelection - 1]].UseItem();
        Console.WriteLine($"You have redeemed {_items[inventoryIndex[redeemSelection - 1]].GetName()}. ");
    }
    public void IncreaseQuantity(){
        DisplaySelection();
        Console.WriteLine("Which item would you like to increase the quantity of? (enter the number) ");
        int increaseSelection = int.Parse(Console.ReadLine());
        _items[increaseSelection - 1].AddShopQuantity();
    }
    public void DisplaySelection(){
        int index = 1;
        foreach (Item item in _items){
            Console.WriteLine($"\n{index}. {item.GetName()}");
            index ++;
        }
    }
}