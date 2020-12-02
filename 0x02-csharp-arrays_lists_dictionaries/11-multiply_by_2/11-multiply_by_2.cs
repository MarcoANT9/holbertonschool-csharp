using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        // Creates a new dictionary to copy the info from the first and not modify the first.
        Dictionary<string, int> myNewDict = new Dictionary<string, int>();
        foreach (string element in myDict.Keys)
            myNewDict[element] = myDict[element] * 2;

        return (myNewDict);
    }
}

