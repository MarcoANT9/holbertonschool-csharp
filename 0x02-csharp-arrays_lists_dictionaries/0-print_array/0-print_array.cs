using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return (null);
        }
        if (size == 0)
            Console.WriteLine();
        int[] num_array = new int[size];
        for (int i = 0; i < num_array.Length; i++)
        {
            num_array[i] = i;
            if (i < num_array.Length - 1)
                Console.Write(num_array[i] + " ");
            else
                Console.Write(num_array[i] + "\n");
        }
        return (num_array);

    }
}