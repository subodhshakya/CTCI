using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._022_Generate_Parentheses
{
    class Solution
    {
        public IList<string> GenerateParenthesis(int n)
        {
            IList<string> ans = new List<string>();
            if (n == 1)
            {
                ans.Add("()");
                return ans;
            }

            IList<string> closure = GenParenthesisHelper(n);

            foreach (string c in closure)
            {
                if (c.Length == n * 2)
                {
                    ans.Add(c);
                }
            }

            return ans;
        }

        // Approach 3 from the solution: Closure Number
        private IList<string> GenParenthesisHelper(int n)
        {
            IList<string> ans = new List<string>();

            ans.Add("");

            /*
            Main logic: "(" + all seq of n - 1 + ")" + all seq of n - 1

            */
            for (int c = 0; c < n; c++)
            {
                foreach (string left in GenParenthesisHelper(c))
                {
                    foreach (string right in GenParenthesisHelper(n - 1 - c))
                    {
                        ans.Add("(" + left + ")" + right);
                    }
                }
            }

            return ans;
        }
    }
}
