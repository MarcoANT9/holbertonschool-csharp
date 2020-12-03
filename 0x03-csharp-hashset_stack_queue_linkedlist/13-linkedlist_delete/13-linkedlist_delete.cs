using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> currentNode = myLList.First;
        if (index == myLList.Count)
            myLList.RemoveLast();
        else
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

