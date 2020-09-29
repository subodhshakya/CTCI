using System;
using System.Collections.Generic;
using System.Text;
using CTCILibrary.YouTubeDemos.LeetCode.Common;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._160_Intersection_of_Two_Linked_Lists
{
    public class Solution
    {
        public ListNode GetIntersectionNode(ListNode headA, ListNode headB)
        {
            int listALength = 0;
            int listBLength = 0;
            ListNode currentA = headA;
            ListNode currentB = headB;
            while (currentA != null)
            {
                listALength += 1;
                currentA = currentA.next;
            }
            while (currentB != null)
            {
                listBLength += 1;
                currentB = currentB.next;
            }

            if (listALength > listBLength)
            {
                int difference = listALength - listBLength;
                while (difference != 0)
                {
                    headA = headA.next;
                    difference--;
                }
            }
            else if (listBLength > listALength)
            {
                int difference = listBLength - listALength;
                while (difference != 0)
                {
                    headB = headB.next;
                    difference--;
                }
            }

            while (headA != headB)
            {
                headA = headA.next;
                headB = headB.next;
            }

            return headA;
        }
    }
}
