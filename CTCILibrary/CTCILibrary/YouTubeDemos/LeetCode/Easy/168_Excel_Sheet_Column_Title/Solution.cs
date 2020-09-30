using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._168_Excel_Sheet_Column_Title
{
    public class Solution
    {
        public string ConvertToTitle(int n)
        {
            String columnName = "";

            while (n > 0)
            {
                int rem = n % 26;

                // If remainder is 0, then a 
                // 'Z' must be there in output 
                if (rem == 0)
                {
                    columnName = "Z" + columnName;
                    n = (n / 26) - 1;
                }

                // If remainder is non-zero 
                else
                {
                    columnName = (char)((rem - 1) + 'A') + columnName;
                    n = n / 26;
                }
            }

            return columnName.ToString();
        }

        /// <summary>
        /// This is other way around. i.e. Title to number
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>        
        public int titleToNumber(string s)
        {
            // This process is similar to  
            // binary-to-decimal conversion  
            int result = 0;
            for (int i = 0; i < s.Length; i++)
            {
                result *= 26;
                result += s[i] - 'A' + 1;
            }
            return result;
        }
    }
}
