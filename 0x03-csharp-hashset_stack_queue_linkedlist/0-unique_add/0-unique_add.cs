using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var uniqList = new HashSet<int>(myList);
        int suma = 0;
        foreach(int element in uniqList)
            suma += element;
        return(suma);
    }
}

