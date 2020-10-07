using CTCILibrary.YouTubeDemos.LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._206_Reverse_Linked_List
{
    /*
     * Reverse a singly linked list.

        Example:

        Input: 1->2->3->4->5->NULL
        Output: 5->4->3->2->1->NULL
        Follow up:

        A linked list can be reversed either iteratively or recursively. Could you implement both?
     */
    public class Solution
    {
        public ListNode ReverseList(ListNode head)
        {
            return ReverseListRecursive(head);
        }

        public ListNode ReverseListRecursive(ListNode head)
        {
            if (head == null || head.next == null)
                return head;

            ListNode newHeadNode = ReverseListRecursive(head.next);

            head.next.next = head;
            head.next = null;

            return newHeadNode;
        }

        public ListNode ReverseListIterative(ListNode head)
        {
            if (head == null || head.next == null)
                return head;
            Stack<ListNode> nodeStack = new Stack<ListNode>();
            ListNode current = head;
            while (current != null)
            {
                nodeStack.Push(current);
                current = current.next;
            }

            head = nodeStack.Pop();
            current = head;

            while (nodeStack.Count != 0)
            {
                current.next = nodeStack.Pop();
                current = current.next;
            }

            if (current != null)
                current.next = null;

            return head;
        }
    }
}
