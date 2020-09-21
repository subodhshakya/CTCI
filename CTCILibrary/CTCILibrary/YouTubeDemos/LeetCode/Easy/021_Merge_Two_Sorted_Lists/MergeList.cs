using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._021_Merge_Two_Sorted_Lists
{
    /* 
     * Merge two sorted linked lists and return it as a new sorted list. The new list should be made by splicing together the nodes of the first two lists.

        Example:

        Input: 1->2->4, 1->3->4
        Output: 1->1->2->3->4->4
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
    class MergeList
    {
        public ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            ListNode head = null;
            ListNode current = null;
            while (l1 != null && l2 != null)
            {
                if (l1.val <= l2.val)
                {
                    AddToMergedList(ref head, ref current, ref l1);
                }
                else
                {
                    AddToMergedList(ref head, ref current, ref l2);
                }
            }
            if (l1 != null)
            {
                while (l1 != null)
                {
                    AddToMergedList(ref head, ref current, ref l1);
                }
            }
            if (l2 != null)
            {
                while (l2 != null)
                {
                    AddToMergedList(ref head, ref current, ref l2);
                }
            }
            return head;
        }

        public void AddToMergedList(ref ListNode head, ref ListNode current, ref ListNode listNode)
        {
            if (head == null)
            {
                head = current = new ListNode(listNode.val);
            }
            else
            {
                current.next = new ListNode(listNode.val);
                current = current.next;
            }
            listNode = listNode.next;
        }
    }
}
