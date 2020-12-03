using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> currentNode = myLList.First;

        if (myLList != null && index == myLList.Count - 1)
            myLList.RemoveLast();

        else if (myLList != null && index == 0)
            myLList.RemoveFirst();

        else
        {
            if (myLList != null && index >= 0)
            {
                for (int i = 0; i <= index && currentNode != null; i++)
                {
                    if (i == index)
                    {
                        myLList.Remove(currentNode);
                        break;
                    }
                    currentNode = currentNode.Next;
                }
            }
        }
    }
}

