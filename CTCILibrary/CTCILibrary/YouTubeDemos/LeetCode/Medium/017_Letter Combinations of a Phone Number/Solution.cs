using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._017_Letter_Combinations_of_a_Phone_Number
{
    class Solution
    {
        public IList<string> LetterCombinations(string digits)
        {
            return LetterCombinationsBFS(digits);
        }

        private List<String> LetterCombinationsBFS(String digits)
        {
            Dictionary<char, string> map = new Dictionary<char, string>();
            map.Add('2', "abc");
            map.Add('3', "def");
            map.Add('4', "ghi");
            map.Add('5', "jkl");
            map.Add('6', "mno");
            map.Add('7', "pqrs");
            map.Add('8', "tuv");
            map.Add('9', "wxyz");

            List<String> l = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return l;
            }

            l.Add("");

            for (int i = 0; i < digits.Length; i++)
            {
                List<string> temp = new List<string>();
                string option = map[digits[i]];

                for (int j = 0; j < l.Count; j++)
                {
                    for (int p = 0; p < option.Length; p++)
                    {
                        temp.Add(new StringBuilder(l[j]).Append(option[p]).ToString());
                    }
                }

                l = new List<string>();
                l.AddRange(temp);
            }

            return l;
        }

        private List<String> LetterCombinationsDFS(String digits)
        {
            Dictionary<char, string> dict = new Dictionary<char, string>();
            dict.Add('2', "abc");
            dict.Add('3', "def");
            dict.Add('4', "ghi");
            dict.Add('5', "jkl");
            dict.Add('6', "mno");
            dict.Add('7', "pqrs");
            dict.Add('8', "tuv");
            dict.Add('9', "wxyz");

            List<string> result = new List<string>();
            if (digits == null || digits.Length == 0)
            {
                return result;
            }

            char[] arr = new char[digits.Length];
            helper(digits, 0, dict, result, arr);

            return result;
        }

        private void helper(String digits, int index, Dictionary<char, string> dict,
                                List<String> result, char[] arr)
        {
            if (index == digits.Length)
            {
                result.Add(new String(arr));
                return;
            }

            char number = digits[index];
            string candidates = dict[number];
            for (int i = 0; i < candidates.Length; i++)
            {
                arr[index] = candidates[i];
                helper(digits, index + 1, dict, result, arr);
            }
        }
    }
}
