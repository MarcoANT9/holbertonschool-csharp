using System;

namespace _4_print_hexa
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int number = 0; number < 99; number++)
            {
                Console.Write($"{number:D} = 0x{number:x}\n");

            }
        }
    }
}
