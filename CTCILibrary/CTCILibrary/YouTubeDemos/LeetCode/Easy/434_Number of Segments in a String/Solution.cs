using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._434_Number_of_Segments_in_a_String
{
    class Solution
    {
        public int CountSegments(string s)
        {
            int count = 0;
            if (!string.IsNullOrEmpty(s))
            {
                string[] parts = s.Split(' ');
                foreach (string p in parts)
                {
                    if (!string.IsNullOrEmpty(p))
                        count++;
                }
            }

            return count;
        }
    }
}
