using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._175_Combine_Two_Tables
{
    class Solution
    {
        /*
         * SQL Schema
            Table: Person

            +-------------+---------+
            | Column Name | Type    |
            +-------------+---------+
            | PersonId    | int     |
            | FirstName   | varchar |
            | LastName    | varchar |
            +-------------+---------+
            PersonId is the primary key column for this table.
            Table: Address

            +-------------+---------+
            | Column Name | Type    |
            +-------------+---------+
            | AddressId   | int     |
            | PersonId    | int     |
            | City        | varchar |
            | State       | varchar |
            +-------------+---------+
            AddressId is the primary key column for this table.
 

            Write a SQL query for a report that provides the following information for each person in the Person table, regardless if there is an address for each of those people:

            FirstName, LastName, City, State
         */

        #region Query
        // Select Person.FirstName, Person.LastName, Address.City, Address.State 
        //                      From Person 
        //                      LEFT JOIN 
        //                      Address On Person.PersonId = Address.PersonId 
        #endregion
    }
}
