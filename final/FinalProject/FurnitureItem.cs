public class FurnitureItem : Item{
    private string _material;


    public FurnitureItem(string name, string description, string color, int price, string material) : base(name, "Furniture", color, description, price){
        _material = material;
    }
    public override string DisplayItem()
    {
        return base.DisplayItem()+" Material: " + _material;
    }
    public override string PrepareSave(){
        return base.PrepareSave() + ",\"" + _material + "\"";
    }

}