using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._024_Swap_Nodes_in_Pairs
{
    class Solution
    {
        public ListNode SwapPairs(ListNode head)
        {
            ListNode dummy = new ListNode(0);
            dummy.next = head;
            ListNode pre = dummy;
            while (head != null && head.next != null)
            {
                ListNode n2 = head.next;
                head.next = n2.next;
                n2.next = head;
                pre.next = n2;
                pre = head;
                head = head.next;
            }
            return dummy.next;
        }
    }
}
