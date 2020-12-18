using System;

namespace Text
{
    /// <summary>This is the classic string class, or is it?.</summary>
    public class Str
    {
        /// <summary>This method counts the number of letters on a string using
        /// the camelCase format.</summary>
        public static int CamelCase(string s)
        {
            if (s.Length == 0)
                return 0;
            
            int counter = 1;

            for (int i = 0; i < s.Length; i++)
            {
                if (s[i] >= 65 && s[i] <= 90)
                    counter++;
            }
            return counter;
        }
    }
}
