using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._119_Pascals_Triangle_II
{
    public static class Solution
    {
        public static IList<int> GetRow(int rowIndex)
        {
            List<int> nthPTriangle = new List<int>();

            IList<int> previousNthTriangle = null;
            if (rowIndex > 1)
            {
                previousNthTriangle = GetRow(rowIndex - 1);
            }
                
            for (int i = 0; i < rowIndex + 1; i++)
            {
                if (i == 0 || i == (rowIndex))
                {
                    nthPTriangle.Add(1);                    
                }                
                else
                {                    
                    nthPTriangle.Add(previousNthTriangle[i - 1] + previousNthTriangle[i]);                                           
                }
            }

            return nthPTriangle;
        }
    }
}
