﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._011_Container_With_Most_Water
{
    /*  Given n non-negative integers a1, a2, ..., an , where each represents a point at coordinate (i, ai). n vertical lines are drawn such that the two endpoints of the line i is at (i, ai) and (i, 0). Find two lines, which, together with the x-axis forms a container, such that the container contains the most water.

        Notice that you may not slant the container.
 
        Example 1:


        Input: height = [1,8,6,2,5,4,8,3,7]
        Output: 49
        Explanation: The above vertical lines are represented by array [1,8,6,2,5,4,8,3,7]. In this case, the max area of water (blue section) the container can contain is 49.
        Example 2:

        Input: height = [1,1]
        Output: 1
        Example 3:

        Input: height = [4,3,2,1,4]
        Output: 16
        Example 4:

        Input: height = [1,2,1]
        Output: 2
 

        Constraints:

        2 <= height.length <= 3 * 10^4
        0 <= height[i] <= 3 * 10^4
     * 
     */
    public class Solution
    {
        public int MaxArea(int[] height)
        {
            return TwoPointerApproach(height);
        }

        private int TwoPointerApproach(int[] height)
        {
            if (height.Length == 0)
                return 0;

            int i = 0;
            int j = height.Length - 1;
            int maxArea = 0;
            while (i < j)
            {
                int area = 0;
                if (height[i] < height[j])
                {
                    area = height[i] * (j - i);
                }
                else
                {
                    area = height[j] * (j - i);
                }
                if (area > maxArea)
                {
                    maxArea = area;
                }
                if (height[i] <= height[j])
                {
                    i++;
                }
                else
                {
                    j--;
                }
            }
            return maxArea;
        }

        private int BruteForceSoln(int[] height)
        {
            int maxArea = 0;
            for (int i = 0; i < height.Length; i++)
            {
                if (height[i] > 0)
                {
                    for (int j = i + 1; j < height.Length; j++)
                    {
                        if (height[j] > 0)
                        {
                            int area = 0;
                            if (height[i] < height[j])
                            {
                                area = height[i] * (j - i);
                            }
                            else
                            {
                                area = height[j] * (j - i);
                            }
                            if (area > maxArea)
                            {
                                maxArea = area;
                            }
                        }
                    }
                }
            }
            return maxArea;
        }
    }
}
