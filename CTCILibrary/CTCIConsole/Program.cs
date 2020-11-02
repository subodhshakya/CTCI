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
            CTCILibrary.YouTubeDemos.LeetCode.Medium._215_Kth_Largest_Element_in_an_Array.Solution sln = new CTCILibrary.YouTubeDemos.LeetCode.Medium._215_Kth_Largest_Element_in_an_Array.Solution();

            var result = sln.findKthLargest(new int[] { 3, 2, 3, 1, 2, 4, 5, 5, 6 }, 4);
        }
    }
}
