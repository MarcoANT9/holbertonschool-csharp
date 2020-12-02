using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        List<string> dicKeys = new List<string>(myDict.Keys);
        foreach (string element in dicKeys)
            myDict[element] = myDict[element] * 2;
        return (myDict);
    }
}

