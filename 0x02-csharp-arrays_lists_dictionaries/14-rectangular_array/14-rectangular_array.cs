using System;

class Array
{
    static void Main(string[] args)
    {
        int i = 5;
        int j = 5;

        int[,] myArray = new int[i, j];

        myArray[2, 2] = 1;
        for (int w = 0; w < i; w++)
        {
            for (int h = 0; h < j; h++)
            {
                Console.Write(myArray[w, h]);
                if (h < j - 1)
                    Console.Write(" ");
            }
            Console.WriteLine();
        }
    }
}

