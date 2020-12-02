using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        if (myList.Count == 0)
            return ("None");

        int max_value = -1;
        string name = "";
        foreach (string element in myList.Keys)
        {
            if (myList[element] > max_value)
            {
                max_value = myList[element];
                name = element;
            }
        }
        if (name == "")
            return ("None");
        return (name);
    }
}

