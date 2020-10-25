using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._350_Intersection_of_Two_Arrays_II
{
    class Solution
    {
        public int[] Intersect(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> intCountMap = new Dictionary<int, int>();
            for (int i = 0; i < nums1.Length; i++)
            {
                if (intCountMap.ContainsKey(nums1[i]))
                {
                    intCountMap[nums1[i]]++;
                }
                else
                    intCountMap.Add(nums1[i], 1);
            }

            List<int> overLapList = new List<int>();
            for (int i = 0; i < nums2.Length; i++)
            {
                if (intCountMap.ContainsKey(nums2[i]) && intCountMap[nums2[i]] > 0)
                {
                    overLapList.Add(nums2[i]);
                    intCountMap[nums2[i]]--;
                }
            }

            return overLapList.ToArray();
        }
    }
}
