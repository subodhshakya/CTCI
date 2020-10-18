using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._268_Missing_Number
{
    class Solution
    {
        public int MissingNumber(int[] nums)
        {
            return MissingNumberUsingMath(nums);
        }

        public int MissingNumberUsingMath(int[] nums)
        {
            int sum = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
            }

            int n = nums.Length;
            return (n * (n + 1) / 2) - sum;
        }

        public int MissingNumberUsingLoop(int[] nums)
        {
            int max = int.MinValue;
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] > max)
                    max = nums[i];
            }

            bool[] numFlag = new bool[max + 1];
            for (int i = 0; i < nums.Length; i++)
            {
                numFlag[nums[i]] = true;
            }

            for (int i = 0; i < nums.Length; i++)
            {
                if (!numFlag[i])
                    return i;
            }

            return max + 1;
        }
    }
}
