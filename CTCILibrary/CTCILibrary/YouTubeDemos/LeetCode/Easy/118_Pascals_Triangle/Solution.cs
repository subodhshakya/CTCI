using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._118_Pascals_Triangle
{
    public static class Solution
    {
        public static IList<IList<int>> Generate(int numRows)
        {
            List<List<int>> pTriangle = new List<List<int>>();
            if (numRows == 0)
            {
                pTriangle.ToArray();
            }            
            else
            {
                for (int i = 0; i < numRows; i++)
                {
                    if (i == 0)
                    {
                        pTriangle.Add(new List<int> { 1 });
                    }
                    else if (i == 1)
                    {                        
                        pTriangle.Add(new List<int> { 1, 1 });
                    }
                    else
                    {
                        List<int> currentList = new List<int>();
                        for (int j = 0; j < (i + 1); j++)
                        {
                            if (j == 0 || j == i)
                            {
                                currentList.Add(1);
                            }
                            else
                            {
                                currentList.Add(pTriangle[i - 1][j - 1] + pTriangle[i - 1][j]);
                            }
                        }
                        pTriangle.Add(currentList);
                    }                    
                }
            }

            return pTriangle.ToArray();
        }
    }
}
