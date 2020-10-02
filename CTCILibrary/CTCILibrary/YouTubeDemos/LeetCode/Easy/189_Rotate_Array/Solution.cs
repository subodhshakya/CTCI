using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._189_Rotate_Array
{
    class Solution
    {
        /// <summary>
        /// Brute Force
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate(int[] nums, int k)
        {
            if (nums.Length == 1)
                return;
            for (int i = 0; i < k; i++)
            {
                int temp = nums[nums.Length - 1];
                for (int j = nums.Length - 2; j >= 0; j--)
                {
                    nums[j + 1] = nums[j];
                }
                nums[0] = temp;
            }
        }

        /// <summary>
        /// Using extra array
        /// Time: O(n)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate2(int[] nums, int k)
        {
            int[] a = new int[nums.Length];
            for (int i = 0; i < nums.Length; i++)
            {
                a[(i + k) % nums.Length] = nums[i];
            }

            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = a[i];
            }
        }

        /// <summary>
        /// Using cyclic rotation
        /// Time: O(n)
        /// Space: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void Rotate3(int[] nums, int k)
        {
            k = k % nums.Length;
            int count = 0;
            for (int start = 0; count < nums.Length; start++)
            {
                int current = start;
                int prev = nums[start];
                do
                {
                    int next = (current + k) % nums.Length;
                    int temp = nums[next];
                    nums[next] = prev;
                    prev = temp;
                    current = next;
                    count++;
                } while (start != current);
            }
        }

        /// <summary>
        /// Using reverse:
        /// Time: O(n)
        /// Space: O(1)
        /// </summary>
        /// <param name="nums"></param>
        /// <param name="k"></param>
        public void rotate4(int[] nums, int k)
        {
            k %= nums.Length;
            reverse(nums, 0, nums.Length - 1);
            reverse(nums, 0, k - 1);
            reverse(nums, k, nums.Length - 1);
        }
        public void reverse(int[] nums, int start, int end)
        {
            while (start < end)
            {
                int temp = nums[start];
                nums[start] = nums[end];
                nums[end] = temp;
                start++;
                end--;
            }
        }
    }
}
