using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        foreach (int element in myLList)
        {
            if (element > n)
                {
                    myLList.AddBefore(myLList.Find(element), n);
                    break;
                }
        }
        
        return (myLList.Find(n));
    }
}

