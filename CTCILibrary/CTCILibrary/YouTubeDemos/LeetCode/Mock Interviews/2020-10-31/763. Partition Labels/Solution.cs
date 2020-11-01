using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Mock_Interviews._2020_10_31._763._Partition_Labels
{
    /* Problem: PARTITION LABELS
     
     MAIN LOGIC: GREEDY ALGORITHM         
     */

    #region Description
    /* A string S of lowercase English letters is given. We want to partition this string into as many parts as possible so that each letter appears in at most one part, and return a list of integers representing the size of these parts.
 
        Example 1:

        Input: S = "ababcbacadefegdehijhklij"
        Output: [9,7,8]
        Explanation:
        The partition is "ababcbaca", "defegde", "hijhklij".
        This is a partition so that each letter appears in at most one part.
        A partition like "ababcbacadefegde", "hijhklij" is incorrect, because it splits S into less parts.     

    Note:

    S will have length in range [1, 500].
    S will consist of lowercase English letters ('a' to 'z') only.
     */
    #endregion

    #region Solution
    /*  Intuition

        Let's try to repeatedly choose the smallest left-justified partition. Consider the first label, say it's 'a'. The first partition must include it, and also the last occurrence of 'a'. However, between those two occurrences of 'a', there could be other labels that make the minimum size of this partition bigger. For example, in "abccaddbeffe", the minimum first partition is "abccaddb". This gives us the idea for the algorithm: For each letter encountered, process the last occurrence of that letter, extending the current partition [anchor, j] appropriately.

        Algorithm

        We need an array last[char] -> index of S where char occurs last. Then, let anchor and j be the start and end of the current partition. If we are at a label that occurs last at some index after j, we'll extend the partition j = last[c]. If we are at the end of the partition (i == j) then we'll append a partition size to our answer, and set the start of our new partition to i+1.     
     */
    #endregion

    public class Solution
    {
        public IList<int> PartitionLabels(string S)
        {
            int[] last = new int[26];
            for (int i = 0; i < S.Length; ++i)
                last[(int)S[i] - (int)'a'] = i;

            int j = 0, anchor = 0;
            List<int> ans = new List<int>();
            for (int i = 0; i < S.Length; ++i)
            {
                j = Math.Max(j, last[(int)S[i] - (int)'a']);
                if (i == j)
                {
                    ans.Add(i - anchor + 1);
                    anchor = i + 1;
                }
            }
            return ans;
        }
    }
}
