using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            int l;
            for (l = 97; l <= 122; l++)
            {
                if (l == 101 || l == 113)
                    l++;
                char character = Convert.ToChar(l);
                Console.Write($"{character}");
            }
        }
    }
}
