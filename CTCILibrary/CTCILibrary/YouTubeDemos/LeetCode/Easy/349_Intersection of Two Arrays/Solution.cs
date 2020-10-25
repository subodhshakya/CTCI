using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._349_Intersection_of_Two_Arrays
{
    class Solution
    {
        public int[] Intersection(int[] nums1, int[] nums2)
        {
            HashSet<int> nums1Set = new HashSet<int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1Set.Add(nums1[i]);
            }

            HashSet<int> overLapSet = new HashSet<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (nums1Set.Contains(nums2[i]))
                {
                    overLapSet.Add(nums2[i]);
                }
            }

            return overLapSet.ToArray();
        }
    }
}
