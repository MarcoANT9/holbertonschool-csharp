using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> true_false = new List<bool>();
        foreach (int element in myList)
        {
            if (element % 2 == 0)
                true_false.Add(true);
            else
                true_false.Add(false);
        }
        return (true_false);
    }
}

