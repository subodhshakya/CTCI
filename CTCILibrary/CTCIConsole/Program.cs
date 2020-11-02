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
            CTCILibrary.YouTubeDemos.LeetCode.Medium._127_Word_Ladder.Solution sln = new CTCILibrary.YouTubeDemos.LeetCode.Medium._127_Word_Ladder.Solution();

            var result = sln.LadderLength("hit", "cog", new List<string> { "hot", "dot", "dog", "lot", "log", "cog" });
        }
    }
}
