using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._204_Count_Primes
{
    /*
     * 
     * Count the number of prime numbers less than a non-negative number, n. 

        Example 1:

        Input: n = 10
        Output: 4
        Explanation: There are 4 prime numbers less than 10, they are 2, 3, 5, 7.
        Example 2:

        Input: n = 0
        Output: 0
        Example 3:

        Input: n = 1
        Output: 0
 

        Constraints:

        0 <= n <= 5 * 10^6
     */
    public class Solution
    {
        public int CountPrimes(int n)
        {
            return CountPrimeFast(n);
        }

        private int CountPrimeFast(int n)
        {
            if (n <= 2)
                return 0;
            bool[] primes = new bool[n];
            for (int i = 2; i < n; i++)
                primes[i] = true;
            for (int i = 2; i < n; i++)
            {
                if (primes[i])
                {
                    for (int j = i + i; j < n; j += i)
                    {
                        primes[j] = false;
                    }
                }
            }

            int countPrime = 0;
            for (int i = 2; i < n; i++)
            {
                if (primes[i])
                    countPrime++;
            }

            return countPrime;
        }

        private int CountPrimeSlow(int n)
        {
            int primeCount = 0;
            for (int i = 0; i < n; i++)
            {
                if (IsPrime(i))
                    primeCount++;
            }

            return primeCount;
        }

        private bool IsPrime(int n)
        {
            if (n == 0 || n == 1)
                return false;

            for (int i = 2; i < n; i++)
            {
                if (n % i == 0)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
