using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._463_Island_Perimeter
{
    class Solution
    {
        public int IslandPerimeter(int[][] grid)
        {
            int count = 0;
            for (int i = 0; i < grid.Length; i++)
            {
                for (int j = 0; j < grid[0].Length; j++)
                {
                    if (grid[i][j] == 1)
                    {
                        // Top
                        if (IsWater(grid, i - 1, j))
                            count++;
                        // Left
                        if (IsWater(grid, i, j - 1))
                            count++;
                        // Right
                        if (IsWater(grid, i, j + 1))
                            count++;
                        // Down
                        if (IsWater(grid, i + 1, j))
                            count++;
                    }
                }
            }

            return count;
        }

        private bool IsWater(int[][] grid, int row, int col)
        {
            int maxRow = grid.Length;
            int maxCol = grid[0].Length;
            if (row >= 0 && row < maxRow && col >= 0 && col < maxCol)
            {
                if (grid[row][col] == 0)
                    return true;
            }
            else
                return true;

            return false;
        }
    }
}
