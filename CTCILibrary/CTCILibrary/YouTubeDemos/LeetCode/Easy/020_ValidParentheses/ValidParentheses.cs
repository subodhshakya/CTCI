using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode._020_ValidParentheses
{
    class ValidParentheses
    {
        /* 20. Valid Parentheses
         * Given a string s containing just the characters '(', ')', '{', '}', '[' and ']', determine if the input string is valid.

            An input string is valid if:

            Open brackets must be closed by the same type of brackets.
            Open brackets must be closed in the correct order.
         * 
         *  Example 1:

            Input: s = "()"
            Output: true
            Example 2:

            Input: s = "()[]{}"
            Output: true
            Example 3:

            Input: s = "(]"
            Output: false
         */
        public bool IsValid(string s)
        {
            if (string.IsNullOrEmpty(s))
                return false;

            Stack<char> brackets = new Stack<char>();
            foreach (char c in s)
            {
                if (c == '(' || c == '[' || c == '{')
                {
                    brackets.Push(c);
                }
                else if (c == ')' || c == ']' || c == '}')
                {
                    if (brackets.Count != 0)
                    {
                        char openingBracket = brackets.Pop();
                        if (!((openingBracket == '(' && c == ')') ||
                            (openingBracket == '[' && c == ']') ||
                            (openingBracket == '{' && c == '}')))
                        {
                            return false;
                        }
                    }
                    else
                        return false;
                }
            }
            if (brackets.Count == 0)
                return true;
            else
                return false;
        }
    }
}
