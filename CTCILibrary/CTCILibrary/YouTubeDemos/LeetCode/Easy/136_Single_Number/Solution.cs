using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._136_Single_Number
{
    public static class Solution
    {
        public static int SingleNumber(int[] nums)
        {
            HashSet<int> numberSet = new HashSet<int>();
            for (int i = 0; i < nums.Length; i++)
            {
                if (numberSet.Contains(nums[i]))
                {
                    numberSet.Remove(nums[i]);
                }
                else
                {
                    numberSet.Add(nums[i]);
                }
            }
            return numberSet.First();
        }

        /// <summary>
        /// This uses XOR operator
        /// Main logic
        /// a XOR 0 = a
        /// a XOR a = 0
        /// a XOR b XOR b = a
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public static int SingleNumberOptimized(int[] nums)
        {
            int a = 0;
            foreach (int n in nums)
            {
                a = a ^ n;
            }
            return a;
        }
    }
}
