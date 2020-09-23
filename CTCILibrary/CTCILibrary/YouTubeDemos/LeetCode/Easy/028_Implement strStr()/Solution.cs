using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._028_Implement_strStr__
{
    class Solution
    {
        public int StrStr(string haystack, string needle)
        {
            if (string.IsNullOrEmpty(needle))
            {
                return 0;
            }
            if (needle.Length > haystack.Length)
            {
                return -1;
            }

            for (int i = 0; i < haystack.Length; i++)
            {
                int needleIndex = 0;
                int hayStackIndex = i;
                while ((hayStackIndex < haystack.Length
                      && needleIndex < needle.Length
                      && haystack[hayStackIndex] == needle[needleIndex]))
                {
                    hayStackIndex++;
                    needleIndex++;
                }
                if (needleIndex == needle.Length)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}
