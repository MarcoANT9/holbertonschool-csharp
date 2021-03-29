using System;
using Math;

namespace InventoryLibrary
{
    /// <summary>
    /// This is the class used to create items.
    /// </summary>
    public class Item : BaseClass
    {
        string name;
        string description;
        float price;
        list<string> tags = new list<string>("Item");

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
            this.price = Math.Round(price, 2);
        }

    }
}