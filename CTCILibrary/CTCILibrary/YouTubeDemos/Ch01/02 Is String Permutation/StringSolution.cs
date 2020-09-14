using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch01._02_Is_String_Permutation
{
    public class StringSolution
    {
        public static void TestMethod()
        {
            string s1 = "hello world";
            string s2 = " dehllllorw";
            string s3 = "whlleo ordl";
            Console.WriteLine("Is s1 permutation of s2: " + IsPermutation(s1, s3));
        }
        public static bool IsPermutation(string s1, string s2)
        {
            if (s1.Length != s2.Length)
            {
                return false;
            }

            int[] characterCount = new int[256];

            foreach (char c in s1)
            {
                int asciiValue = (int)c;
                characterCount[asciiValue]++;
            }

            foreach (char c in s2)
            {
                int asciiValue = (int)c;
                characterCount[asciiValue]--;
                if (characterCount[asciiValue] < 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
