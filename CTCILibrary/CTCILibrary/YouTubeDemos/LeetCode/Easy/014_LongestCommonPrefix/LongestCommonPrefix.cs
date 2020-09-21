using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode._014_LongestCommonPrefix
{
    class LongestCommonPrefix
    {
        public string GetLongestCommonPrefix(string[] strs)
        {
            if (strs == null || strs.Length == 0)
                return string.Empty;
            int minLength = int.MaxValue;
            foreach (string s in strs)
            {
                if (string.IsNullOrEmpty(s))
                    return string.Empty;
                if (s.Length > 0 && minLength > s.Length)
                {
                    minLength = s.Length;
                }
            }

            if (minLength == 0) return string.Empty;

            for (int i = 0; i < minLength; i++)
            {
                char prev = '0';
                for (int j = 0; j < strs.Length; j++)
                {
                    if (j == 0)
                    {
                        prev = strs[j][i];
                        continue;
                    }
                    if (strs[j][i] != prev)
                    {
                        return strs[j].Substring(0, i);
                    }
                }
            }

            return strs[0].Substring(0, minLength);
        }
    }
}
