﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._197_Rising_Temperature
{
    /*
     * 197. Rising Temperature
     * Table: Weather

        +---------------+---------+
        | Column Name   | Type    |
        +---------------+---------+
        | id            | int     |
        | recordDate    | date    |
        | temperature   | int     |
        +---------------+---------+
        id is the primary key for this table.
        This table contains information about the temperature in a certain day.
 

        Write an SQL query to find all dates' id with higher temperature compared to its previous dates (yesterday).

        Return the result table in any order.

        The query result format is in the following example:

        Weather
        +----+------------+-------------+
        | id | recordDate | Temperature |
        +----+------------+-------------+
        | 1  | 2015-01-01 | 10          |
        | 2  | 2015-01-02 | 25          |
        | 3  | 2015-01-03 | 20          |
        | 4  | 2015-01-04 | 30          |
        +----+------------+-------------+

        Result table:
        +----+
        | id |
        +----+
        | 2  |
        | 4  |
        +----+
        In 2015-01-02, temperature was higher than the previous day (10 -> 25).
        In 2015-01-04, temperature was higher than the previous day (30 -> 20).
     * 
     */
    class Solution
    {
        /*
         * # Write your MySQL query statement below
            SELECT
                weather.id AS 'Id'
            FROM
                weather
                    JOIN
                weather w ON DATEDIFF(weather.recordDate, w.recordDate) = 1
                    AND weather.Temperature > w.Temperature
            ;
         * 
         */
    }
}
