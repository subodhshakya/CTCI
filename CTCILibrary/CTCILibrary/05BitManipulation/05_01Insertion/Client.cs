using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary._05BitManipulation._05_01Insertion
{
    public static class Client
    {
        public static void Run()
        {
            int n = 1024; // in Binary N= 10000000000 
            DecToBinary(n);
            int m = 19; // in Binary M= 10011 
            DecToBinary(m);
            int i = 2;
            int j = 6;

            int output = Insertion.UpdateBits(n, m, i, j);
            DecToBinary(output);
        }

        public static void DecToBinary(int n)
        {
            int[] a = new int[11];
            int i;
            for (i = 0; n > 0; i++)
            {
                a[i] = n % 2;
                n = n / 2;
            }
            Console.Write("Binary of the given number= ");
            for (i = i - 1; i >= 0; i--)
            {
                Console.Write(a[i]);
            }
            Console.WriteLine();
        }
    }
}
