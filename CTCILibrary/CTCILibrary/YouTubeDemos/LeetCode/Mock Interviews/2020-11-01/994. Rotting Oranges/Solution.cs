using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Mock_Interviews._2020_11_01._994._Rotting_Oranges
{
    /* Rotting oranges:
     *  In a given grid, each cell can have one of three values:

        the value 0 representing an empty cell;
        the value 1 representing a fresh orange;
        the value 2 representing a rotten orange.
        Every minute, any fresh orange that is adjacent (4-directionally) to a rotten orange becomes rotten.

        Return the minimum number of minutes that must elapse until no cell has a fresh orange.  If this is impossible, return -1 instead.
     * 
     * Example 1:
        Input: [[2,1,1],[1,1,0],[0,1,1]]
        Output: 4

        Example 2:
        Input: [[2,1,1],[0,1,1],[1,0,1]]
        Output: -1
        Explanation:  The orange in the bottom left corner (row 2, column 0) is never rotten, because rotting only happens 4-directionally.
        
        Example 3:
        Input: [[0,2]]
        Output: 0
        Explanation:  Since there are already no fresh oranges at minute 0, the answer is just 0.

        Note:

        1 <= grid.length <= 10
        1 <= grid[0].length <= 10
        grid[i][j] is only 0, 1, or 2.
     * 
     * SOLUTION:
     * 
     * Approach 1: Breadth-First Search (BFS)
        Intuition

        This is yet another 2D traversal problem. As we know, the common algorithmic strategies to deal with these problems would be Breadth-First Search (BFS) and Depth-First Search (DFS).

        As suggested by its name, the BFS strategy prioritizes the breadth over depth, i.e. it goes wider before it goes deeper. On the other hand, the DFS strategy prioritizes the depth over breadth.

        The choice of strategy depends on the nature of the problem. Though sometimes, they are both applicable for the same problem. In addition to 2D grids, these two algorithms are often applied to problems associated with tree or graph data structures as well.

        In this problem, one can see that BFS would be a better fit.

        Because the process of rotting could be explained perfectly with the BFS procedure, i.e. the rotten oranges will contaminate their neighbors first, before the contamination propagates to other fresh oranges that are farther away.

        If one is not familiar with the algorithm of BFS, one can refer to our Explore card of Queue & Stack which covers this subject.

        However, it would be more intuitive to visualize the rotting process with a graph data structure, where each node represents a cell and the edge between two nodes indicates that the given two cells are adjacent to each other.


        In the above graph (pun intended), as we can see, starting from the top rotten orange, the contamination would propagate layer by layer (or level by level), until it reaches the farthest fresh oranges. The number of minutes that are elapsed would be equivalent to the number of levels in the graph that we traverse during the propagation.
     */
    public class Solution
    {
        public int OrangesRotting(int[][] grid)
        {
            Queue<Tuple<int, int>> queue = new Queue<Tuple<int, int>>();

            // Step 1). build the initial set of rotten oranges
            int freshOranges = 0;
            int ROWS = grid.Length, COLS = grid[0].Length;

            for (int r = 0; r < ROWS; ++r)
                for (int c = 0; c < COLS; ++c)
                    if (grid[r][c] == 2)
                        queue.Enqueue(new Tuple<int, int>(r, c));
                    else if (grid[r][c] == 1)
                        freshOranges++;

            // Mark the round / level, _i.e_ the ticker of timestamp
            queue.Enqueue(new Tuple<int, int>(-1, -1));

            // Step 2). start the rotting process via BFS
            int minutesElapsed = -1;
            int[][] directions = { new int[] { -1, 0 }, new int[] { 0, 1 }, new int[] { 1, 0 }, new int[] { 0, -1 } };

            while (queue.Count != 0)
            {
                Tuple<int, int> p = queue.Dequeue();
                int row = p.Item1;
                int col = p.Item2;
                if (row == -1)
                {
                    // We finish one round of processing
                    minutesElapsed++;
                    // to avoid the endless loop
                    if (queue.Count != 0)
                        queue.Enqueue(new Tuple<int, int>(-1, -1));
                }
                else
                {
                    // this is a rotten orange
                    // then it would contaminate its neighbors
                    foreach (int[] d in directions)
                    {
                        int neighborRow = row + d[0];
                        int neighborCol = col + d[1];
                        if (neighborRow >= 0 && neighborRow < ROWS &&
                            neighborCol >= 0 && neighborCol < COLS)
                        {
                            if (grid[neighborRow][neighborCol] == 1)
                            {
                                // this orange would be contaminated
                                grid[neighborRow][neighborCol] = 2;
                                freshOranges--;
                                // this orange would then contaminate other oranges
                                queue.Enqueue(new Tuple<int, int>(neighborRow, neighborCol));
                            }
                        }
                    }
                }
            }

            // return elapsed minutes if no fresh orange left
            return freshOranges == 0 ? minutesElapsed : -1;
        }
    }
}
