using System;

namespace Text
{
    /// <summary>This is the classic Str class.</summary>
    public class Str
    {
        ///<summary>This method receives a string and returns the index of the
        /// first repeating element or -1 if no char repeats.</summary>
        public static int UniqueChar(string s)
        {
            if (s == null || s == "")
                return -1;
            int i = 0;
            int j = 0;
            while (i < s.Length)
            {
                j = i + 1;
                while (j < s.Length)
                {
                    if (s[i] == s[j])
                        return i;
                    j++;
                }
                i++;
            }
            return -1;
        }
    }
}
