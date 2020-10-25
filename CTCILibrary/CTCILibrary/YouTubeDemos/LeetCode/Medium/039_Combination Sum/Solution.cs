using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._039_Combination_Sum
{
    public class Solution
    {
        public IList<IList<int>> CombinationSum(int[] candidates, int target)
        {
            List<int> list = new List<int>();
            IList<IList<int>> result = new List<IList<int>>();
            Backtrack(candidates, list, 0, 0, target, result);
            return result;
        }

        public void Backtrack(int[] candidates, List<int> list, int start, int sum, int target, IList<IList<int>> result)
        {
            if (sum > target)
                return;

            if (sum == target)
            {
                result.Add(new List<int> (list));
                return;
            }

            for (int i = start; i < candidates.Length; i++)
            {
                list.Add(candidates[i]);
                Backtrack(candidates, list, i, sum + candidates[i], target, result);
                list.RemoveAt(list.Count - 1);
            }
        }
    }
}
