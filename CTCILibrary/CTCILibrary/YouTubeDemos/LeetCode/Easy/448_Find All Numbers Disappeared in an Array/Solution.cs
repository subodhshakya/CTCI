using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._448_Find_All_Numbers_Disappeared_in_an_Array
{
    class Solution
    {
        public IList<int> FindDisappearedNumbers(int[] nums)
        {
            return FindMissingWithoutExtraMem(nums);
        }

        public IList<int> FindMissingWithExtraMem(int[] nums)
        {
            List<int> missingItems = new List<int>();

            HashSet<int> numsSet = new HashSet<int>();
            foreach (int i in nums)
            {
                numsSet.Add(i);
            }

            for (int i = 1; i <= nums.Length; i++)
            {
                if (!numsSet.Contains(i))
                {
                    missingItems.Add(i);
                }
            }

            return missingItems;
        }

        public IList<int> FindMissingWithoutExtraMem(int[] nums)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[Math.Abs(nums[i]) - 1] > 0)
                {
                    nums[Math.Abs(nums[i]) - 1] *= -1;
                }
            }

            List<int> missingItems = new List<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > 0)
                    missingItems.Add(i + 1);
            }

            return missingItems;
        }
    }
}
