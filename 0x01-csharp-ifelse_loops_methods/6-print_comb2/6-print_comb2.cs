using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int i = 0; i < 9; i++){
                for (int j = i + 1; j < 10; j++){
                    if (i == 8 && j == 9)
                        Console.Write($"{i}{j}\n");
                    else
                        Console.Write($"{i}{j}, ");
                }
            }
        }
    }
}
