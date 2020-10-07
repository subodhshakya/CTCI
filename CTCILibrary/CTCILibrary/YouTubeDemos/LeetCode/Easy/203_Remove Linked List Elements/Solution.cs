using CTCILibrary.YouTubeDemos.LeetCode.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._203_Remove_Linked_List_Elements
{
    /*
     * 
     * Remove all elements from a linked list of integers that have value val.

        Example:

        Input:  1->2->6->3->4->5->6, val = 6
        Output: 1->2->3->4->5
     */
    public class Solution
    {
        public ListNode RemoveElements(ListNode head, int val)
        {
            ListNode current = head;
            ListNode previous = null;
            while (current != null)
            {
                if (current.val == val)
                {
                    if (previous != null)
                        previous.next = current.next;
                    else
                        head = head.next;
                }
                else
                {
                    previous = current;
                }
                current = current.next;
            }

            if (previous == null)
                head = null;

            return head;
        }
    }
}
