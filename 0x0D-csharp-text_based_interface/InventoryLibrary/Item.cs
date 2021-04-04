using System;


//namespace InventoryLibrary
//{
/// <summary>
/// This is the class used to create items.
/// </summary>
public class Item : BaseClass
{
    public string name { get; set; }
    public string description { get; set; }
    public float price { get; set; }


    /// <summary>
    /// Class Constructor.
    /// </summary>
    /// <param name="name">Item Name.</param>
    /// <param name="description">Item Description.</param>
    /// <param name="price">Item Price.</param>
    public Item(string name = "Default_Item_Name", string description = "Default_Item_Description", float price = 0.0f)
    {
        this.name = name;
        this.description = description;
        this.price = Convert.ToSingle(Math.Round(price, 2));
    }


    public override string ToString()
    {
        string returnValue = $"Object: {this.GetType().Name}\nName: {this.name}\nId: {this.id}\nDescription: {this.description}\nPrice: {this.price}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
        return (returnValue);
    }

}
//}