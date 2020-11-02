using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CTCILibrary;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCIConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            CTCILibrary.YouTubeDemos.LeetCode.Medium._056_Merge_Intervals.Solution sln = new CTCILibrary.YouTubeDemos.LeetCode.Medium._056_Merge_Intervals.Solution();

            sln.Merge(new int[][] { new int[] { 1, 4 }, new int[] { 2, 3 }});
        }
    }
}
