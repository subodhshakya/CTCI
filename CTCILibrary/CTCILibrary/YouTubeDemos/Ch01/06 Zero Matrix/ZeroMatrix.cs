using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch01._06_Zero_Matrix
{
    class ZeroMatrix
    {
        static void Main(string[] args)
        {
            //: Input: Matrix
            //: Output: Zero Matrix
            int[,] matrix = GetMatrix();
            PrintMatrix(matrix);
            Console.WriteLine("Set zero");
            //SetZeroInMatrix(matrix);
            SetZeroInMatrixOptimized(matrix);
            PrintMatrix(matrix);
        }

        static int[,] GetMatrix()
        {
            int[,] matrix = new int[5, 5]
                {
                    { 1 ,2 ,0 ,4, 21 },
                    { 5 ,6 ,7 ,8, 78 },
                    { 9 ,10,11,0, 91 },
                    { 13,14,15,16, 4 },
                    { 7 ,96, 1, 4, 7 }
                };
            return matrix;
        }

        static void SetZeroInMatrix(int[,] matrix)
        {
            bool[] row = new bool[matrix.GetLength(0)];
            bool[] column = new bool[matrix.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        row[i] = true;
                        column[j] = true;
                    }
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    if (row[i] || column[j])
                    {
                        matrix[i, j] = 0;
                    }
                }
            }
        }

        static void SetZeroInMatrixOptimized(int[,] matrix)
        {
            bool firstRowHasZero = false;
            bool firstColumnHasZero = false;
            for (int i = 0; i < matrix.GetLength(1); i++)
            {
                if (matrix[0, i] == 0)
                {
                    firstRowHasZero = true;
                    break;
                }
            }

            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                if (matrix[i, 0] == 0)
                {
                    firstColumnHasZero = true;
                    break;
                }
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, j] == 0)
                    {
                        matrix[i, 0] = 0;
                        matrix[0, j] = 0;
                    }
                }
            }

            for (int i = 1; i < matrix.GetLength(0); i++)
            {
                for (int j = 1; j < matrix.GetLength(1); j++)
                {
                    if (matrix[i, 0] == 0 || matrix[0, j] == 0)
                    {
                        matrix[i, j] = 0;
                    }
                }
            }

            if (firstRowHasZero)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[0, j] = 0;
                }
            }

            if (firstColumnHasZero)
            {
                for (int i = 0; i < matrix.GetLength(0); i++)
                {
                    matrix[i, 0] = 0;
                }
            }
        }

        static void PrintMatrix(int[,] matrix)
        {
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    Console.Write(matrix[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
