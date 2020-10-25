using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Easy._414_Third_Maximum_Number
{
    class Solution
    {
        public int ThirdMax(int[] nums)
        {
            int firstMax = int.MinValue;
            int secondMax = int.MinValue;
            int thirdMax = int.MinValue;
            bool thirdMinFound = false;

            foreach (int i in nums)
            {
                if (i > firstMax)
                    firstMax = i;
            }

            foreach (int i in nums)
            {
                if (i > secondMax && i < firstMax)
                    secondMax = i;
            }

            foreach (int i in nums)
            {
                if (i >= thirdMax && i < secondMax)
                {
                    thirdMax = i;
                    thirdMinFound = true;
                }
            }

            if (thirdMinFound)
                return thirdMax;

            return firstMax;
        }

        // Single iteration approach below:
        /*
        static void thirdLargest(int[] arr, int arr_size)  
        {     
            if (arr_size < 3) 
            { 
                Console.Write(" Invalid Input "); 
                return; 

            } 

            // Initialize first, second and third Largest element 
            int first = arr[0], second = int.MinValue, 
                                    third = int.MinValue; 

            // Traverse array elements to find the third Largest 
            for (int i = 1; i < arr_size; i++)  
            { 
                //If current element is greater than first, 
                then update first, second and third 
                if (arr[i] > first) { 
                    third = second; 
                    second = first; 
                    first = arr[i]; 
                } 

                //If arr[i] is in between first and second
                else if (arr[i] > second) { 
                    third = second; 
                    second = arr[i]; 
                }  
                //If arr[i] is in between second and third
                else if (arr[i] > third) { 
                    third = arr[i]; 
                } 
            } 

            Console.Write("The third Largest element is "+ third); 
        } 
        */
    }
}
