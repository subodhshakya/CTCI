using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._345_Reverse_Vowels_of_a_String
{
    class Solution
    {
        public string ReverseVowels(string s)
        {
            int j = 0;

            // Storing the vowels separately 
            char[] str = s.ToCharArray();
            String vowel = "";
            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    j++;
                    vowel += str[i];
                }
            }

            // Placing the vowels in the reverse 
            // order in the string 
            for (int i = 0; i < str.Length; i++)
            {
                if (IsVowel(str[i]))
                {
                    str[i] = vowel[--j];
                }
            }

            return String.Join("", str);
        }

        private bool IsVowel(char c)
        {
            return (c == 'a' || c == 'A' ||
                    c == 'e' || c == 'E' ||
                    c == 'i' || c == 'I' ||
                    c == 'o' || c == 'O' ||
                    c == 'u' || c == 'U');
        }
    }
}
