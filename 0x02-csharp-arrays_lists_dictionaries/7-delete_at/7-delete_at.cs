using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index >= myList.Count || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return (myList);
        }
        int count = 0;
        for (int i = 0; i < index; i++)
            count++;
        myList.Remove(myList[count]);
        return(myList);
    }
}

