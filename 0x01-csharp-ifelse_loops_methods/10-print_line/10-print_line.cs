using System;

class Line
{
    public static void PrintLine(int length)
    {
        if (length <= 0)
            Console.Write("\n");
        else
        {
            for (int i = 0; i < length; i++)
            {
                Console.Write("_");
            }
        }
    }
}
