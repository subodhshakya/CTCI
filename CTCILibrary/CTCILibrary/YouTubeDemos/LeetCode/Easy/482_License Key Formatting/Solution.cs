using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._482_License_Key_Formatting
{
    class Solution
    {
        // Logic I used:
        // Start from end
        // If '-' encountered, skip it
        // If segment count reaches K then insert '-'
        public string LicenseKeyFormatting(string S, int K)
        {
            int nonDashCount = 0;
            foreach (char c in S)
            {
                if (c != '-')
                    nonDashCount++;
            }
            int segmentCounter = 0;
            int insertedCharCount = 0;
            StringBuilder sbFormatedKey = new StringBuilder();
            for (int i = S.Length - 1; i >= 0; i--)
            {
                if (S[i] == '-')
                    continue;

                sbFormatedKey.Insert(0, char.ToUpper(S[i]));
                segmentCounter++;
                insertedCharCount++;

                if (segmentCounter == K && insertedCharCount < nonDashCount)
                {
                    sbFormatedKey.Insert(0, '-');
                    segmentCounter = 0;
                }
            }

            return sbFormatedKey.ToString();
        }
    }
}
