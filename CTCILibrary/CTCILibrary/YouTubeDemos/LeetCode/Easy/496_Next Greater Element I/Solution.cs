using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._496_Next_Greater_Element_I
{
    class Solution
    {
        public int[] NextGreaterElement(int[] nums1, int[] nums2)
        {
            Dictionary<int, int> pairs = new Dictionary<int, int>();
            Stack<int> stack = new Stack<int>();
            foreach (int num in nums2)
            {
                // Stack is used to see what came before
                while (stack.Count > 0 && stack.Peek() < num)
                {
                    // This map creates key = next smaller number to left, 
                    // value = current number
                    pairs.Add(stack.Pop(), num);
                }
                stack.Push(num);
            }
            for (int i = 0; i < nums1.Length; i++)
            {
                nums1[i] = pairs.ContainsKey(nums1[i]) ? pairs[nums1[i]] : -1;
            }
            return nums1;
        }
    }
}
