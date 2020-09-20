using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.Ch01._05_Matrix_Rotation
{
    class MatrixRotation
    {
        public static void TestMethod()
        {
            //: Input: Matrix
            //: Output: Rotate matrix 90 degree clockwise
            int[,] matrix = GetMatrix();
            PrintMatrix(matrix);
            RotateMatrixClockwise(matrix);
            Console.WriteLine("After rotation");
            PrintMatrix(matrix);
            RotateMatrixAntiClockwise(matrix);
            Console.WriteLine("After anti clockwise rotation");
            PrintMatrix(matrix);
        }
        static int[,] GetMatrix()
        {
            int[,] matrix = new int[4, 4]
                {
                    { 1 ,2 ,3 ,4  },
                    { 5 ,6 ,7 ,8  },
                    { 9 ,10,11,12 },
                    { 13,14,15,16 }
                };
            return matrix;
        }

        static void RotateMatrixClockwise(int[,] matrix)
        {
            int layers = matrix.GetLength(0) / 2;
            for (int i = 0; i < layers; i++)
            {
                int first = i;
                int last = matrix.GetLength(0) - i - 1;
                for (int j = first; j < last; j++)
                {
                    int offset = j - first;

                    // Move left to top
                    int top = matrix[first, j];
                    int left = matrix[last - offset, first];
                    matrix[first, j] = left;

                    // Move bottom to left
                    int bottom = matrix[last, last - offset];
                    matrix[last - offset, first] = bottom;

                    // Move right to bottom
                    int right = matrix[j, last];
                    matrix[last, last - offset] = right;

                    // Move top to right
                    matrix[j, last] = top;
                }
            }
        }

        static void RotateMatrixAntiClockwise(int[,] matrix)
        {
            int layers = matrix.GetLength(0) / 2;
            for (int i = 0; i < layers; i++)
            {
                int first = i;
                int last = matrix.GetLength(0) - i - 1;
                for (int j = first; j < last; j++)
                {
                    int offset = j - first;

                    // Move right to top
                    int top = matrix[first, last - offset];
                    int right = matrix[last - offset, last];
                    matrix[first, last - offset] = right;

                    // Move bottom to right
                    int bottom = matrix[last, j];
                    matrix[last - offset, last] = bottom;

                    // Move left to bottom
                    int left = matrix[j, first];
                    matrix[last, j] = left;

                    // Move top to left
                    matrix[j, first] = top;
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
