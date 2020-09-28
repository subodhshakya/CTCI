using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._125_Valid_Palindrome
{
    public static class Solution
    {
        /*
         * Given a string, determine if it is a palindrome, considering only alphanumeric characters and ignoring cases.

            Note: For the purpose of this problem, we define empty string as valid palindrome.

            Example 1:

            Input: "A man, a plan, a canal: Panama"
            Output: true
            Example 2:

            Input: "race a car"
            Output: false
 

            Constraints:

            s consists only of printable ASCII characters.
            => Meaning use ASCII value range to exclude non alphanumeric character.
            => However can also use C# build in Char.IsNumber or Char.IsLetter function. They also does the same thing.
         */
        public static bool IsPalindrome(string s)
        {
            if (String.IsNullOrEmpty(s))
                return true;

            int start = 0;
            int end = s.Length - 1;
            bool hasAlphaNumeric = false;
            while (start < end)
            {
                while (start < s.Length && !(Char.IsNumber(s[start]) || Char.IsLetter(s[start])))
                    start++;
                while (end > 0 && !(Char.IsNumber(s[end]) || Char.IsLetter(s[end])))
                    end--;

                if ((start >= s.Length || end < 0) && !hasAlphaNumeric)
                    return true;

                if (!hasAlphaNumeric && (Char.IsNumber(s[start]) ||
                   Char.IsLetter(s[start]) ||
                  Char.IsNumber(s[end]) ||
                   Char.IsLetter(s[end])))
                {
                    hasAlphaNumeric = true;
                }

                if (Char.ToUpper(s[start]) != Char.ToUpper(s[end]))
                    return false;

                start++;
                end--;
            }

            return true;
        }
    }
}
