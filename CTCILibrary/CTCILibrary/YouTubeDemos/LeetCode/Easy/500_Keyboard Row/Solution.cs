using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._500_Keyboard_Row
{
    class Solution
    {
        public string[] FindWords(string[] words)
        {
            HashSet<char> firstRow = new HashSet<char> { 'Q', 'W', 'E', 'R', 'T', 'Y', 'U', 'I', 'O', 'P' };
            HashSet<char> secondRow = new HashSet<char> { 'A', 'S', 'D', 'F', 'G', 'H', 'J', 'K', 'L' };
            HashSet<char> thirdRow = new HashSet<char> { 'Z', 'X', 'C', 'V', 'B', 'N', 'M' };

            List<string> result = new List<string>();
            foreach (string w in words)
            {
                bool[] rowFlag = new bool[3];
                foreach (char c in w)
                {
                    if (firstRow.Contains(char.ToUpper(c)))
                        rowFlag[0] = true;
                    if (secondRow.Contains(char.ToUpper(c)))
                        rowFlag[1] = true;
                    if (thirdRow.Contains(char.ToUpper(c)))
                        rowFlag[2] = true;
                }
                int rowContainsCount = 0;
                foreach (bool f in rowFlag)
                {
                    if (f)
                        rowContainsCount++;
                }
                if (rowContainsCount == 1)
                    result.Add(w);
            }

            return result.ToArray();
        }
    }
}
