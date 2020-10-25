using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._019_Remove_Nth_Node_From_End_of_List
{
    class Solution
    {
        /*
    Two pointer approach:
    Move the first pointer by n steps forward
    Then move first and second pointer until first pointer reaches the end
    second pointer should have reached the node that should be deleted.
    Delete second pointer.
    */
        public ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            ListNode pointer1 = head;
            ListNode pointer2 = head;
            ListNode previous2 = null;
            int count = 1;
            while (count <= n && pointer1 != null)
            {
                pointer1 = pointer1.next;
                count++;
            }

            while (pointer1 != null)
            {
                pointer1 = pointer1.next;
                previous2 = pointer2;
                pointer2 = pointer2.next;
            }

            if (previous2 != null)
            {
                previous2.next = pointer2.next;
            }
            else if (pointer2 == head)
            {
                head = head.next;
            }

            return head;
        }
    }
}
