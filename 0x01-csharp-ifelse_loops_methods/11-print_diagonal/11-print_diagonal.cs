using System;


class Line
{
    public static void PrintDiagonal(int length)
    {
        if (length <= 0)
            Console.Write("\n");
        else
        {
            for (int i = 0; i < length; i++)
            {
                for (int j = 0; j <= i; j++)
                {
                    if (j == i)
                    {
                        Console.Write("\\");
                        Console.Write("\n");
                    }
                    else
                        Console.Write(" ");
                }
            }
        }
    }
}

