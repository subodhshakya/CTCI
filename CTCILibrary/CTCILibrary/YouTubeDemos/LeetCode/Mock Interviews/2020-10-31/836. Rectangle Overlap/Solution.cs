using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Mock_Interviews._2020_10_31._836._Rectangle_Overlap
{
    /* Problem: RECTANGLE OVERLAP 
     
     MAIN LOGIC: GEOMETRY OF MATHEMATICS => PROJECTION IN X AND Y AXIS
     
     */    

    /* DESCRIPTION OF PROBLEM:
     * -----------------------
     *  An axis-aligned rectangle is represented as a list [x1, y1, x2, y2], where (x1, y1) is the coordinate of its bottom-left corner, and (x2, y2) is the coordinate of its top-right corner. Its top and bottom edges are parallel to the X-axis, and its left and right edges are parallel to the Y-axis.

        Two rectangles overlap if the area of their intersection is positive. To be clear, two rectangles that only touch at the corner or edges do not overlap.

        Given two axis-aligned rectangles rec1 and rec2, return true if they overlap, otherwise return false. 

        Example 1:

        Input: rec1 = [0,0,2,2], rec2 = [1,1,3,3]
        Output: true
        Example 2:

        Input: rec1 = [0,0,1,1], rec2 = [1,0,2,1]
        Output: false
        Example 3:

        Input: rec1 = [0,0,1,1], rec2 = [2,2,3,3]
        Output: false
     * 
     * 
     * 
     * Solution: Area overlap approach
     * 
     * Intuition
        If the rectangles overlap, they have positive area. This area must be a rectangle where both dimensions are positive, since the boundaries of the intersection are axis aligned.
        Thus, we can reduce the problem to the one-dimensional problem of determining whether two line segments overlap.

        Algorithm
        Say the area of the intersection is width * height, where width is the intersection of the rectangles projected onto the x-axis, and height is the same for the y-axis. We want both quantities to be positive.
        The width is positive when min(rec1[2], rec2[2]) > max(rec1[0], rec2[0]), that is when the smaller of (the largest x-coordinates) is larger than the larger of (the smallest x-coordinates). The height is similar.
     * 
     */
    class Solution
    {
        public bool IsRectangleOverlap(int[] rec1, int[] rec2)
        {
            return (Math.Min(rec1[2], rec2[2]) > Math.Max(rec1[0], rec2[0]) && // width > 0
                    Math.Min(rec1[3], rec2[3]) > Math.Max(rec1[1], rec2[1]));  // height > 0
            #region My Understanding            
            /* Draw projection of x1 and x2 of both rectangles then middle two lines should overlap
             * 
             * Smilarly draw project of y1 and y2 of both rectangles then middle two lines should overlap
             * 
             */
            #endregion
        }
    }
}
