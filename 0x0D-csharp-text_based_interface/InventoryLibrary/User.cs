using System;

//namespace InventoryLibrary
//{
/// <summary>
/// This is the class used to create users.
/// </summary>
public class User : BaseClass
{
    public string name { get; set; }

    /// <summary>
    /// Class Constructor.
    /// </summary>
    /// <param name="name">User name.</param>
    public User(string name = "Default_User_Name")
    {
        this.name = name;
    }

    public override string ToString()
    {
        string returnValue = $"Object: {this.GetType().Name}\nName: {this.name}\nId: {this.id}\nCreation Date: {this.date_created}\nUpdated Date: {this.date_updated}";
        return (returnValue);
    }

}
//}