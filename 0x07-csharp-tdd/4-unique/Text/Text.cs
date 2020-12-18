using System;

namespace Text
{
    /// <summary>This is the classic Str class.</summary>
    public class Str
    {
        ///<summary>This method receives a string and returns the index of the
        /// first non-repeating element or -1 if no char repeats.</summary>
        public static int UniqueChar(string s)
        {
            if (s.Length == 0)
                return -1;

            int i = 0;
            int j;
            string repeated = "";
            bool contains;

            while (i < s.Length)
            {
                if (repeated.Contains(s[i].ToString()))
                    i++;
                else
                {
                    contains = false;
                    j = i + 1;
                    while (j < s.Length)
                    {
                        if (s[i] == s[j])
                        {
                            repeated += s[j];
                            contains = true;
                            break;
                        }
                        j++;
                    }
                    if (contains == false)
                        return i;
                    i++;
                }
            }
            return -1;
        }
    }
}
