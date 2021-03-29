using System;
using System.IO;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Collections.Generic;

namespace InventoryLibrary
{
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
        Dictionary<TKey, TValue> objects = new Dictionary<TKey, TValue>();


        // ~ Methods ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
        /// <summary>
        /// This method returns all dictionary.
        /// </summary>
        /// <returns>Objects Dictionary</returns>
        public Dictionary<TKey, TValue> All()
        {
            return (this.objects);
        }

        /// <summary>
        /// Adds a new element to the current dictionary.
        /// </summary>
        /// <param name="obj">Objecto to save into de Dict.</param>
        public void New(object obj)
        {
            objects.Add(obj.name + "." + obj.id, obj);
        }

        /// <summary>
        /// Serializes the objects dictionary into JSON format and saves it
        /// into the JSON Storage file (../Storage/inventory_manager.JSON).
        /// </summary>
        public void Save()
        {
            string jsonString = JsonSerializer.Serialize(objects);
            string filePath = @"../Storage/inventory_manager.json";
            using (StreamWriter sw = File.OpenWrite(filePath))
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
            string filePath = @"../Storage/inventory_manager.json";
            string jsonString = File.ReadAllText(filePath);
            objects = JsonSerializer.deserialize(jsonString);
        }
    }
}