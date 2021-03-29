using System;
using System.Text.Json;
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
        public object All()
        {
            return (this.objects);
        }


    }
}