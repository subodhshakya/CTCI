using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._002_Add_Two_Numbers
{
    /*  You are given two non-empty linked lists representing two non-negative integers. The digits are stored in reverse order, and each of their nodes contains a single digit. Add the two numbers and return the sum as a linked list.

        You may assume the two numbers do not contain any leading zero, except the number 0 itself.
 
        Example 1:


        Input: l1 = [2,4,3], l2 = [5,6,4]
        Output: [7,0,8]
        Explanation: 342 + 465 = 807.
        Example 2:

        Input: l1 = [0], l2 = [0]
        Output: [0]
        Example 3:

        Input: l1 = [9,9,9,9,9,9,9], l2 = [9,9,9,9]
        Output: [8,9,9,9,0,0,0,1]
 

        Constraints:

        The number of nodes in each linked list is in the range [1, 100].
        0 <= Node.val <= 9
        It is guaranteed that the list represents a number that does not have leading zeros.
     * 
     * 
     * 
     */

    public class ListNode
    {
        public int val;
        public ListNode next;
        public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution
    {
        ListNode sumHead = null;
        ListNode sum = null;
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
        {
            int carry = 0;
            while (l1 != null && l2 != null)
            {
                Sum(l1.val, l2.val, ref carry);
                l1 = l1.next;
                l2 = l2.next;
            }

            while (l1 != null)
            {
                Sum(l1.val, 0, ref carry);
                l1 = l1.next;
            }

            while (l2 != null)
            {
                Sum(0, l2.val, ref carry);
                l2 = l2.next;
            }

            if (carry > 0)
            {
                Sum(0, 0, ref carry);
            }

            return sumHead;
        }

        private void Sum(int val1, int val2, ref int carry)
        {
            int valueSum = val1 + val2 + carry;
            if (valueSum > 9)
            {
                carry = 1;
                valueSum = valueSum % 10;
            }
            else
                carry = 0;

            ListNode currentSum = new ListNode(valueSum);
            if (sum == null)
                sum = currentSum;
            else
            {
                sum.next = currentSum;
                sum = sum.next;
            }
            if (sumHead == null)
                sumHead = sum;
        }
    }
}
