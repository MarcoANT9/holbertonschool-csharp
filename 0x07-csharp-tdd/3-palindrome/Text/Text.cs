using System;
using System.Collections.Generic;

namespace Text
{
    /// <summary>This is the standard str class aparently. </summary>
    public class str
    {
        /// <summary>This method determines if a string is a palindrome or not
        /// whitout taking into account spaces and punctuation and being case
        /// insensitive.</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s == "")
                return true;

            string _s = s.ToLower();
            List<char> punctuation = new List<char>();
            punctuation.Add(' ');
            punctuation.Add(',');
            punctuation.Add('.');
            punctuation.Add(':');
            punctuation.Add(';');

            int i = 0;
            int j = s.Length - 1;

            while (i <= j)
            {
                if (punctuation.Contains(_s[i]))
                {
                    i++;
                    continue;
                }
                if (punctuation.Contains(_s[j]))
                {
                    j--;
                    continue;
                }
                if (_s[i] == _s[j])
                {
                    i++;
                    j--;
                }
                else
                    return false;
            }
            return true;
        }
    }
}
