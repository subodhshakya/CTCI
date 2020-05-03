using CTCILibrary._04TreesAndGraphs._04_11RandomNode;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._04TreesAndGraphs._04_12PathsWithSum
{
    public class PathsWithSum
    {
        public int CountPathsWithSum(TreeNode root, int targetSum)
        {
            return CountPathsWithSum(root, targetSum, 0, new Dictionary<int, int>());
        }

        public int CountPathsWithSum(TreeNode node, int targetSum, int runningSum, Dictionary<int, int> pathCount)
        {
            if (node == null) return 0; // base case

            // Count paths with sum ending at the current node.
            runningSum += node.data;
            int sum = runningSum - targetSum;
            int totalPaths = pathCount.ContainsKey(sum) ? pathCount[sum] : 0;

            // If runningSum equals targetSum, then one additional path starts at root.
            // Add in this path.
            if (runningSum == targetSum)
            {
                totalPaths++;
            }

            // Increment pathCount, recurse, then decrement pathCount
            IncrementHashTable(pathCount, runningSum, 1); // Increment path count
            totalPaths += CountPathsWithSum(node.Left, targetSum, runningSum, pathCount);
            totalPaths += CountPathsWithSum(node.Right, targetSum, runningSum, pathCount);
            IncrementHashTable(pathCount, runningSum, -1); // Decrement path count

            return totalPaths;
        }

        public void IncrementHashTable(Dictionary<int, int> hashTable, int key, int delta)
        {
            int newCount = (hashTable.ContainsKey(key) ? hashTable[key] : 0) + delta;
            if (newCount == 0)
            {
                hashTable.Remove(key);
            }
            else
            {
                hashTable[key] = newCount;
            }
        }
    }
}
