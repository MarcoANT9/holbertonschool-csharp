﻿using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int count = 0;
        
        foreach (int i in myLList)
            count++;
        
        return (count);
    }
}
