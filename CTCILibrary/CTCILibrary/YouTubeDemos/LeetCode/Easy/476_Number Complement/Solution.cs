using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._476_Number_Complement
{
    class Solution
    {
        public int FindComplement(int num)
        {
            int index = 0;
            int flip_num = 0;
            while (num > 0)
            {
                // Careful, when bitwise and is 1, set 0 otherwise 1 * 2 ^ index
                flip_num += (num & 1) == 1 ? 0 : (int)Math.Pow(2, index);
                index++;
                num = num >> 1;
            }
            return flip_num;
        }
    }
}
