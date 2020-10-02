using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._176_Second_Highest_Salary
{
    class Solution
    {
        /* Write your T-SQL query statement below 
            --Below query uses nested query to get second largest salary
            --Query in where clause gets hightest salary.Then condition salary<query #2 returns the highest 
            --after applying MAX(salary) in query #1
            SELECT MAX(salary) AS SecondHighestSalary
                FROM employee
                WHERE salary< (SELECT MAX(salary)
                             FROM employee);
        */
    }
}
