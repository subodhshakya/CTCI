using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._290_Word_Pattern
{
    /*
     * Given a pattern and a string s, find if s follows the same pattern.

Here follow means a full match, such that there is a bijection between a letter in pattern and a non-empty word in s.
     */
    class Solution
    {
        public bool WordPattern(string pattern, string s)
        {
            string[] sParts = s.Split(' ');
            if (sParts.Length > 0)
            {
                if (pattern.Length != sParts.Length)
                {
                    return false;
                }
                else
                {
                    Dictionary<char, string> patternMap = new Dictionary<char, string>();
                    Dictionary<string, char> wordMap = new Dictionary<string, char>();
                    for (int i = 0; i < pattern.Length; i++)
                    {
                        string sPart = sParts[i].Trim();
                        if ((patternMap.ContainsKey(pattern[i]) &&
                           patternMap[pattern[i]] != sPart) ||
                          (wordMap.ContainsKey(sPart) &&
                          wordMap[sPart] != pattern[i]))
                        {
                            return false;
                        }
                        patternMap[pattern[i]] = sPart;
                        wordMap[sPart] = pattern[i];
                    }
                }
            }

            return true;
        }
    }
}
