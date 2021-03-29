using System;

/// <summary>
/// This is the class used to create users.
/// </summary>
public class User : BaseClass
{
    string name;

    /// <summary>
    /// Class Constructor.
    /// </summary>
    /// <param name="name">User name.</param>
    public User (string name = "Default_User_Name")
    {
        this.name = name;
    }
}

