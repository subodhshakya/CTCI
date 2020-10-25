using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._003_Longest_Substring_Without_Repeating_Characters
{
    /* Given a string s, find the length of the longest substring without repeating characters.
     * 
     *  Example 1:

        Input: s = "abcabcbb"
        Output: 3
        Explanation: The answer is "abc", with the length of 3.
        Example 2:

        Input: s = "bbbbb"
        Output: 1
        Explanation: The answer is "b", with the length of 1.
        Example 3:

        Input: s = "pwwkew"
        Output: 3
        Explanation: The answer is "wke", with the length of 3.
        Notice that the answer must be a substring, "pwke" is a subsequence and not a substring.
        Example 4:

        Input: s = ""
        Output: 0
 

        Constraints:

        0 <= s.length <= 5 * 10^4
        s consists of English letters, digits, symbols and spaces.
     */
    public class Solution
    {
        public int LengthOfLongestSubstring(string s)
        {
            return LongestSubstringSlidingWindow(s);
        }

        // Approach 1 - Brute Force!
        public int LongestSubstringBruteForce(string s)
        {
            int maxCount = 0;
            int currentMaxCount = 0;
            for (int i = 0; i < s.Length; i++)
            {
                for (int j = i + 1; j < s.Length; j++)
                {
                    if (IsUnique(s.Substring(i, j - i)))
                    {
                        if ((j - i) > currentMaxCount)
                        {
                            currentMaxCount = j - i;
                        }
                    }
                }
                if (currentMaxCount > maxCount)
                    maxCount = currentMaxCount;
            }
            return maxCount;
        }

        private bool IsUnique(string s)
        {
            HashSet<char> cset = new HashSet<char>();
            foreach (char c in s)
            {
                if (cset.Contains(c))
                {
                    return false;
                }
                else
                    cset.Add(c);
            }
            return true;
        }

        // Approach 2: Sliding Window
        public int LongestSubstringSlidingWindow(string s)
        {
            int n = s.Length;
            HashSet<char> set = new HashSet<char>();
            int ans = 0, i = 0, j = 0;
            while (i < n && j < n)
            {
                // try to extend the range [i, j]
                if (!set.Contains(s[j]))
                {
                    set.Add(s[j++]);
                    ans = Math.Max(ans, j - i);
                }
                else
                {
                    // keeps on removing until char at s[j] is removed so that new
                    // subsequence length can be calculated and set to max
                    set.Remove(s[i++]);
                }
            }
            return ans;
        }
    }
}
