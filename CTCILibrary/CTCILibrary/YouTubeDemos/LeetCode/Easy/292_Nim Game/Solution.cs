﻿using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._292_Nim_Game
{
    /*
     * You are playing the following Nim Game with your friend:

Initially, there is a heap of stones on the table.
You and your friend will alternate taking turns, and you go first.
On each turn, the person whose turn it is will remove 1 to 3 stones from the heap.
The one who removes the last stone is the winner.
Given n, the number of stones in the heap, return true if you can win the game assuming both you and your friend play optimally, otherwise return false.
     * 
     */
    class Solution
    {
        public bool CanWinNim(int n)
        {
            // You can always win a Nim game if the number of stones n in the pile is not divisible by 4
            return (n % 4 != 0);
        }
    }
}
