using System;

namespace InventoryLibrary
{
    /// <summary>
    /// This is the class used to create inventories.
    /// </summary>
    public class Inventory : BaseClass
    {
        string user_id;
        string item_id;
        int quantity;

        /// <summary>
        /// Class Constructor.
        /// </summary>
        /// <param name="user_id">User ID.</param>
        /// <param name="item_id">Item ID.</param>
        /// <param name="quantity">Item Quantity.</param>
        public Inventory(string user_id = "Default_User_Id", string item_id = "Default_Item_Id", int quantity = 1)
        {
            if (quantity < 0)
                quantity = 1;

            this.quantity = quantity;
            this.user_id = user_id;
            this.item_id = item_id;
        }
    }
}