using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._056_Merge_Intervals
{
    public class Solution
    {
        private static void Sort<T>(T[][] data, int col)
        {
            Comparer<T> comparer = Comparer<T>.Default;
            Array.Sort<T[]>(data, (x, y) => comparer.Compare(x[col], y[col]));
        }

        public int[][] Merge(int[][] intervals)
        {
            if (intervals.Length == 0 || intervals.Length == 1)
                return intervals;

            Sort<int>(intervals, 0);
            List<int[]> mergedIntervals = new List<int[]>();

            int start = intervals[0][0];
            int end = intervals[0][1];
            
            for (int i = 1; i < intervals.Length; i++)
            {
                if (end >= intervals[i][0])
                {
                    end = Math.Max(intervals[i][1], end);
                    continue;
                }                    
                else
                {
                    mergedIntervals.Add(new int[] { start, end });
                    start = intervals[i][0];
                    end = Math.Max(intervals[i][1], end);
                }
            }

            //Add last pair
            mergedIntervals.Add(new int[] { start, end });

            return mergedIntervals.ToArray();
        }
    }
}
