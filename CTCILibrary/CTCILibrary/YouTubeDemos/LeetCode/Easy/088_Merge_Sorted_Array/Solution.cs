using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._088_Merge_Sorted_Array
{
    public static class Solution
    {
        public static void Merge(int[] nums1, int m, int[] nums2, int n)
        {
            int mergedIndex = m + n - 1;
            m--;
            n--;
            while (mergedIndex >= 0)
            {
                if (m >= 0 && n >= 0)
                {
                    if (nums1[m] >= nums2[n])
                    {
                        nums1[mergedIndex] = nums1[m];
                        m -= 1;
                    }
                    else
                    {
                        nums1[mergedIndex] = nums2[n];
                        n -= 1;
                    }
                    mergedIndex--;
                }
                if (m < 0 && n >= 0)
                {
                    nums1[mergedIndex] = nums2[n];
                    n -= 1;
                    mergedIndex--;
                }
                if (n < 0 && m >= 0)
                {
                    nums1[mergedIndex] = nums1[m];
                    m -= 1;
                    mergedIndex--;
                }                
            }
        }
    }
}
