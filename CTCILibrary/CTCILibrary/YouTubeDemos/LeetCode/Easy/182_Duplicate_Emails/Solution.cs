using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._182_Duplicate_Emails
{
    class Solution
    {
        /*
         * SELECT DISTINCT p1.Email FROM Person p1 WHERE EXISTS( SELECT * FROM Person p2 WHERE p2.Email = p1.Email AND p2.Id != p1.Id )
         * 
         * 
         */
    }
}
