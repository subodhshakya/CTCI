using CTCILibrary.YouTubeDemos.LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._234_Palindrome_Linked_List
{
    /*
     * Given a singly linked list, determine if it is a palindrome.

        Example 1:

        Input: 1->2
        Output: false
        Example 2:

        Input: 1->2->2->1
        Output: true
        Follow up:
        Could you do it in O(n) time and O(1) space?
     * 
     */
    public class Solution
    {
        public bool IsPalindrome(ListNode head)
        {

            if (head == null || head.next == null)
                return true;

            ListNode fastRunner = head;
            ListNode slowRunner = head;
            while (fastRunner != null && fastRunner.next != null)
            {
                fastRunner = fastRunner.next.next;
                slowRunner = slowRunner.next;
            }

            if (fastRunner != null)
                slowRunner = slowRunner.next;

            Stack<int> valStack = new Stack<int>();
            while (slowRunner != null)
            {
                valStack.Push(slowRunner.val);
                slowRunner = slowRunner.next;
            }

            ListNode current = head;
            while (valStack.Count > 0)
            {
                if (current.val != valStack.Pop())
                {
                    return false;
                }
                current = current.next;
            }

            return true;
        }
    }
}
