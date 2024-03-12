public class PointShop{
    private int _score;
    private List<Item> items;

    public void SetScore(int score){
        _score = score;
    }
    public void DisplayShop(){
        Console.WriteLine("Point Shop");
        Console.WriteLine($"Score: {_score}");
        Console.WriteLine("List of Items: ");
        int itemIndex = 1;
        foreach (Item item in items){
            Console.WriteLine($"{itemIndex}. {item.DisplayItem()}");
            itemIndex ++;
        }
        
        
        
    }

}