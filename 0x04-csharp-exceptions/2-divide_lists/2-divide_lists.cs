using System;
using System.Collections.Generic;

class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        int i = 0;
        List<int> retList = new List<int>();
        int quot;

        while (i < listLength)
        {
            try
            {
                quot = list1[i] / list2[i];
            }
            catch (System.ArgumentOutOfRangeException)
            {
                Console.WriteLine("Out of range");
                break;
            }
            catch (DivideByZeroException)
            {
                Console.WriteLine("Cannot divide by zero");
                quot = 0;
            }
            retList.Add(quot);
            i++;
        }
        return (retList);
    }
}