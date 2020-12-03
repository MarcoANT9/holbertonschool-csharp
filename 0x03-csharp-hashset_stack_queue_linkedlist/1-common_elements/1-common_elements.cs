using System;
using System.Collections.Generic;

class List
{
    public static List<int> CommonElements(List<int> list1, List<int> list2)
    {
        List<int> listSorted = new List<int>();
        foreach (int element in list1)
        {
            foreach (int number in list2)
            {
                if (element == number)
                {
                    listSorted.Add(element);
                    break;
                }
            }
        }
        listSorted.Sort();
        return (listSorted);
    }
}

