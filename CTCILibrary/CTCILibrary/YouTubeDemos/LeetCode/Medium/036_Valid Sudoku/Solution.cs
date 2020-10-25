using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._036_Valid_Sudoku
{
    public class Solution
    {
        public bool IsValidSudoku(char[][] board)
        {
            return IsValidSudokuBruteForce(board);
        }

        public bool IsValidSudokuBruteForce(char[][] board)
        {
            HashSet<char> uniqueNumbers = new HashSet<char>();

            //Iterate through rows
            for (int i = 0; i < board.Length; i++)
            {
                uniqueNumbers = new HashSet<char>();
                //Iterate through columns
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[i][j] == '.')
                    {
                        continue;
                    }
                    double cellValue = char.GetNumericValue(board[i][j]);
                    if (cellValue >= 0 && cellValue <= 9)
                    {
                        if (!uniqueNumbers.Contains(board[i][j]))
                        {
                            uniqueNumbers.Add(board[i][j]);
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }

            //Iterate through columns
            for (int i = 0; i < board.Length; i++)
            {
                uniqueNumbers = new HashSet<char>();
                //Iterate through columns
                for (int j = 0; j < board[i].Length; j++)
                {
                    if (board[j][i] == '.')
                    {
                        continue;
                    }
                    double cellValue = char.GetNumericValue(board[j][i]);
                    if (cellValue >= 0 && cellValue <= 9)
                    {
                        if (!uniqueNumbers.Contains(board[j][i]))
                        {
                            uniqueNumbers.Add(board[j][i]);
                        }
                        else
                            return false;
                    }
                    else
                        return false;
                }
            }

            //Iterate through block of 9 cells
            for (int i = 0; i < board.Length; i += 3)
            {
                //Iterate through columns
                for (int j = 0; j < board[i].Length; j += 3)
                {
                    uniqueNumbers = new HashSet<char>();
                    for (int m = i; m < (i + 3); m++)
                    {
                        for (int n = j; n < (j + 3); n++)
                        {
                            if (board[m][n] == '.')
                            {
                                continue;
                            }
                            double cellValue = char.GetNumericValue(board[m][n]);
                            if (cellValue >= 0 && cellValue <= 9)
                            {
                                if (!uniqueNumbers.Contains(board[m][n]))
                                {
                                    uniqueNumbers.Add(board[m][n]);
                                }
                                else
                                    return false;
                            }
                            else
                                return false;
                        }
                    }
                }
            }

            return true;
        }
    }
}
