using System;

namespace _100_jagged_array
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] jagged_array = new int[3][]
            {
            new int[] {0, 1, 2, 3},
            new int[] { 0, 1, 2, 3, 4, 5, 6 },
            new int[] { 0, 1 }
            };

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < jagged_array[i].Length; j++)
                {
                    Console.Write(jagged_array[i][j]);
                    if (j < jagged_array[i].Length - 1)
                        Console.Write(" ");
                }
                Console.WriteLine();
            }
        }
    }
}
