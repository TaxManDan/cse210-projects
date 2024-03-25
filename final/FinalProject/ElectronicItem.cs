public class ElectronicItem : Item
{
    private string _brand;
    private string _model;
    private string _serialNumber;

    public ElectronicItem(string brand, string model, string serialNumber, string name, string description,string color, int price) : base(name, "Electronic", color, description, price)
    {
        _brand = brand;
        _model = model;
        _serialNumber = serialNumber;
    }
    public override string PrepareSave()
    {
        return base.PrepareSave() + ",\"" + _brand + "\",\"" + _model + "\",\"" + _serialNumber + "\"";
    }

    public override string DisplayItem(){
        return base.DisplayItem();
    }

}