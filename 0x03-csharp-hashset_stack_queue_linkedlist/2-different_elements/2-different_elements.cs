using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        List<int> listSorted = new List<int>();
        foreach (int element in list1)
        {
            int same = 0;
            foreach (int number in list2)
            {
                if (element == number)
                {
                    same = 1;
                    break;
                }
            }
            if (same == 0)
                listSorted.Add(element);
        }
        foreach (int number in list2)
        {
            int same = 0;
            foreach (int element in list1)
            {
                if (number == element)
                {
                    same = 1;
                    break;
                }
            }
            if (same == 0)
                listSorted.Add(number);
        }
        listSorted.Sort();
        return (listSorted);
    }
}
