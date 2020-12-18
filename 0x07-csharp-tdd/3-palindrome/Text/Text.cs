using System;

namespace Text
{
    /// <summary>This is the standard str class aparently. </summary>
    public class Str
    {
        /// <summary>This method determines if a string is a palindrome or not
        /// whitout taking into account spaces and punctuation and being case
        /// insensitive.</summary>
        public static bool IsPalindrome(string s)
        {
            if (s == null || s == "")
                return true;

            string _s = s;
            _s = _s.ToLower();
            _s = _s.Trim(' ', ',', '.', ':', ';');

            int i = 0;
            int j = _s.Length - 1;

            while (i < j)
            {
                if (_s[i] == ' ')
                {
                    i++;
                    continue;
                }
                if (_s[j] == ' ')
                {
                    j--;
                    continue;
                }
                if (_s[i] != _s[j])
                    return false;
                i++;
                j--;
            }
            return true;
        }
    }
}
