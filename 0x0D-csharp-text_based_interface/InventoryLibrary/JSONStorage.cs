using System;
using System.IO;
using System.Collections.Generic;
using System.Text.Json;


//namespace InventoryLibrary
//{

/// <summary>
/// /// This is the class used to create/manage JSON Storage files.
/// </summary>
public class JSONStorage
{
    /// <summary>
    /// This creates the dictionary to store elements.
    /// </summary>
    /// <typeparam name="TKey">ClassName</typeparam>
    /// <typeparam name="TValue">id</typeparam>
    public Dictionary<string, object> objects = new Dictionary<string, object>();

    /// <summary>
    /// Path to Json File.
    /// </summary>
    string filePath = @"./Storage/inventory_manager.json";

    // ~ Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
    /// <summary>
    /// This method returns all dictionary.
    /// </summary>
    /// <returns>Objects Dictionary</returns>
    public Dictionary<string, object> All()
    {
        return (this.objects);
    }

    /// <summary>
    /// Adds a new element to the current dictionary.
    /// </summary>
    /// <param name="obj">Objecto to save into de Dict.</param>
    /// <param name="args">List of arguments to initialize the class.</param>
    public void New(string nameClass, string[] args = null)
    {
        if (nameClass == "item")
        {
            Item newItem = new Item();
            objects.Add(nameClass + "." + newItem.id, newItem);
        }
        else if (nameClass == "user")
        {
            User newUser = new User();
            objects.Add(nameClass + "." + newUser.id, newUser);
        }
        else
        {
            Inventory newInv = new Inventory();
            objects.Add(nameClass + "." + newInv.id, newInv);
        }
    }

    /// <summary>
    /// Serializes the objects dictionary into JSON format and saves it
    /// into the JSON Storage file (../Storage/inventory_manager.JSON).
    /// </summary>
    public void Save()
    {
        var options = new JsonSerializerOptions
        {
            IgnoreNullValues = true,
            WriteIndented = true
        };

        string jsonString = JsonSerializer.Serialize<Dictionary<string, object>>(objects, options);

        using (StreamWriter sw = File.CreateText(filePath))
        {
            sw.WriteLine(jsonString);
        }
    }

    /// <summary>
    /// Reads from the JSON Storage file (../Storage/inventory_manager.JSON)
    /// and deserializes the information into the objects Dictionary.
    /// </summary>
    public void Load()
    {
        string jsonString = "{}";
        try
        {
            using (StreamReader sw = File.OpenText(filePath))
            {
                jsonString = File.ReadAllText(filePath);
            }
            objects = JsonSerializer.Deserialize<Dictionary<string, object>>(jsonString);
        }
        catch (JsonException)
        {
            Console.WriteLine("JSON File does not contain info");
        }
    }
}
//}