using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch01._04_String_Compression
{
    class StringCompression
    {
        static void Main(string[] args)
        {
            //: Input: "aaaeeffwwwwaa"
            //: Output: "a3e2f2w4a2" 
            Console.WriteLine(Compress("aaaeeffwwwwaa"));
        }

        static string CompressBad(string str)
        {
            string compressedString = string.Empty;
            int consecutiveCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                consecutiveCount++;

                if (((i + 1) >= str.Length) || (str[i] != str[i + 1]))
                {
                    compressedString += str[i] + consecutiveCount.ToString();
                    consecutiveCount = 0;
                }
            }

            return compressedString.Length < str.Length ? compressedString : str;
        }

        static string Compress(string str)
        {
            StringBuilder sbCompressed = new StringBuilder();
            int consecutiveCount = 0;

            for (int i = 0; i < str.Length; i++)
            {
                consecutiveCount++;

                if (((i + 1) >= str.Length) || (str[i] != str[i + 1]))
                {
                    sbCompressed.Append(str[i] + consecutiveCount.ToString());
                    consecutiveCount = 0;
                }
            }
            string compressedString = sbCompressed.ToString();
            return compressedString.Length < str.Length ? compressedString : str;
        }
    }
}
