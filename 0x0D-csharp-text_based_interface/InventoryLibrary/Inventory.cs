using System.Text.Json;

//namespace InventoryLibrary
//{
/// <summary>
/// This is the class used to create inventories.
/// </summary>
public class Inventory : BaseClass
{
    public User user { get; set; }
    public Item item { get; set; }
    public int quantity { get; set; }
    public string user_id { get; set; }
    public string item_id { get; set; }

    /// <summary>
    /// Class Constructor.
    /// </summary>
    /// <param name="user_id">User ID.</param>
    /// <param name="item_id">Item ID.</param>
    /// <param name="quantity">Item Quantity.</param>
    public Inventory(User user = null, Item item = null, int quantity = 1)
    {
        if (quantity < 0)
            quantity = 1;

        this.quantity = quantity;
        if (user != null)
            this.user_id = user.id;
        else
            this.user_id = "Default_Item_Id";
        if (item != null)
            this.item_id = item.id;
        else
            this.item_id = "Default_Item_Id";
    }

    public override string ToString()
    {
        string returnValue = $"Object: {this.GetType().Name}\nOwn Id: {this.id}\nUser Id: {this.user_id}\nItem Id: {this.item_id}\nItem Quiantity: {this.quantity}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
        return (returnValue);
    }

}
//}