using System;
using System.Collections.Generic;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        // Create a new list to store the sorted keys in the dict
        List<string> sorted_dict = new List<string>(myDict.Keys);
        // Sort the keys
        sorted_dict.Sort();
        // Print the sorted keys : values
        foreach (string element in sorted_dict)
            Console.WriteLine(element + ": " + myDict[element]);
    }
}

