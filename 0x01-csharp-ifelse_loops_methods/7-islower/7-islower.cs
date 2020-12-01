using System;

namespace _7_islower
{
    class Program
    {
        public static bool IsLower(char c)
        {
            if (c >= 97 && c <= 122)
                return (true);
            return (false);
        }
    }
}
