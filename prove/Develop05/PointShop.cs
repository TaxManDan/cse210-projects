using Microsoft.VisualBasic;

public class PointShop
{

    private int _score;

    private List<Item> _items = new List<Item>();

    // Prompts user for the name cost and quantity of an item and adds item to the list of items.
    public void AddItem()
    {
        Console.Write("What is the name of the item? ");
        string name = Console.ReadLine();
        Console.Write("What is the cost of the item? ");
        int cost = int.Parse(Console.ReadLine());
        Console.Write("What quantity of the item would you like to add? ");
        int quantity = int.Parse(Console.ReadLine());
        Item newItem = new Item(name, cost, quantity);
        _items.Add(newItem);
    }


    //Displays the list of items in the shop with their cost and amount in the shop.
    public void DisplayShop()
    {
        Console.WriteLine("Point Shop");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine("List of Items: ");
        int itemIndex = 1;
        foreach (Item item in _items)
        {
            Console.WriteLine($"{itemIndex}. {item.DisplayItem()}");
            itemIndex++;
        }

    }

    //Getters and setters 
    public void SetScore(int score)
    {
        _score = score;
    }
    public void SetItems(List<Item> items)
    {
        _items = items;
    }
    public List<Item> GetItems()
    {
        return _items;
    }
    public int GetScore()
    {
        return _score;
    }

    public void DisplayShopMenu()
    {
        var file = new File();
        int shopSelection = 0;
        while (shopSelection != 7)
        {

            //Displays the Reward Shop Menu
            Console.Write(
                    "\nReward Shop Menu Options:" +
                    "\n1. Add New Shop Items" +
                    "\n2. List Shop Items" +
                    "\n3. Purchase Item" +
                    "\n4. List Inventory" +
                    "\n5. Adjust Shop Quantities" +
                    "\n6. Redeem Item" +
                    "\n7. Return to Main Menu" +
                    "\nSelect a choice from the menu: ");

            //Get user selection
            shopSelection = int.Parse(Console.ReadLine());
            switch (shopSelection)
            {
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
    public void BuyItem()
    {

        //Display list of items and read user selection
        DisplaySelection();
        Console.Write("Which item would you like to buy? (enter the number) ");
        int itemSelection = int.Parse(Console.ReadLine());

        // Check if user has enough points to buy item
        if (_items[itemSelection - 1].GetCost() > _score)
        {
            Console.WriteLine("You don't have enough points. Try again. ");
        }

        // Check if item is sold out
        else if (_items[itemSelection - 1].GetShopQuantity() == 0)
        {
            Console.WriteLine("That item is sold out. Try again. ");
        }

        // If user has enough points and item is not sold out, buy item and update score
        else
        {
            _score -= _items[itemSelection - 1].GetCost();
            _items[itemSelection - 1].BuyItem();
            Console.WriteLine($"Thank you for your purchase of {_items[itemSelection - 1].GetName()}");
            Console.WriteLine($"You now have {_score} points. ");

        }
    }

    //Displays all items in inventory
    public void DisplayInventory()
    {
        foreach (Item item in _items)
        {
            if (item.GetQuantityOwned() > 0)
            {
                item.DisplayItemInventory();
            }
        }
    }



    public void RedeemItem()
    {
        List<int> inventoryIndex = new List<int>();
        int itemIndex = 0;
        foreach (Item item in _items)
        {

            // Displays Items in users inventory.
            if (item.GetQuantityOwned() > 0)
            {
                Console.WriteLine($"{inventoryIndex.Count + 1}. {item.GetName()}");
                inventoryIndex.Add(itemIndex);
            }
            itemIndex++;
        }

        //Asks which item to redeem and redeems item.
        Console.Write("Which item would you like to redeem? (enter the number) ");
        int redeemSelection = int.Parse(Console.ReadLine());
        _items[inventoryIndex[redeemSelection - 1]].UseItem();
        Console.WriteLine($"You have redeemed {_items[inventoryIndex[redeemSelection - 1]].GetName()}. ");
    }

    // Displays all items and asks which item to increase
    public void IncreaseQuantity()
    {
        DisplaySelection();
        Console.WriteLine("Which item would you like to increase the quantity of? (enter the number) ");
        int increaseSelection = int.Parse(Console.ReadLine());
        _items[increaseSelection - 1].AddShopQuantity();
    }

    //Displays all the Items in a numbered format
    public void DisplaySelection()
    {
        int index = 1;
        foreach (Item item in _items)
        {
            Console.WriteLine($"\n{index}. {item.GetName()}");
            index++;
        }
    }
}