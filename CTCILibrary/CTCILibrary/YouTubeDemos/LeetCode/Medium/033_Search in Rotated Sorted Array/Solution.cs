using System;
using System.Collections.Generic;
using System.Text;

namespace CTCILibrary.YouTubeDemos.LeetCode.Medium._033_Search_in_Rotated_Sorted_Array
{
    /* 33. Search in Rotated Sorted Array
     * 
     * You are given an integer array nums sorted in ascending order, and an integer target.

Suppose that nums is rotated at some pivot unknown to you beforehand (i.e., [0,1,2,4,5,6,7] might become [4,5,6,7,0,1,2]).

If target is found in the array return its index, otherwise, return -1.

        Example 1:

        Input: nums = [4,5,6,7,0,1,2], target = 0
        Output: 4
        Example 2:

        Input: nums = [4,5,6,7,0,1,2], target = 3
        Output: -1
        Example 3:

        Input: nums = [1], target = 0
        Output: -1
 

        Constraints:

        1 <= nums.length <= 5000
        -10^4 <= nums[i] <= 10^4
        All values of nums are unique.
        nums is guranteed to be rotated at some pivot.
        -10^4 <= target <= 10^4
     * 
     */
    public class Solution
    {
        /* Solution: Find pivot where array is rotated then decide on weather to search on left side of pivot or right side of pivot.
         * 
         * Time complexity of binary search: O(log n)
         */
        public int Search(int[] nums, int target)
        {
            return search(nums, 0, nums.Length-1, target);
        }        


        // Searches an element key in a 
        // pivoted sorted array arr[] 
        // of size n 
        public int pivotedBinarySearch(int[] arr,
                                       int n, int key)
        {
            int pivot = findPivot(arr, 0, n - 1);

            // If we didn't find a pivot, then 
            // array is not rotated at all 
            if (pivot == -1)
                return binarySearch(arr, 0, n - 1, key);

            // If we found a pivot, then first 
            // compare with pivot and then 
            // search in two subarrays around pivot 
            if (arr[pivot] == key)
                return pivot;

            if (arr[0] <= key)
                return binarySearch(arr, 0, pivot - 1, key);

            return binarySearch(arr, pivot + 1, n - 1, key);
        }

        /* Function to get pivot. For array  
    3, 4, 5, 6, 1, 2 it returns 
    3 (index of 6) */
        private int findPivot(int[] arr, int low, int high)
        {
            // base cases 
            if (high < low)
                return -1;
            if (high == low)
                return low;

            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (mid < high && arr[mid] > arr[mid + 1])
                return mid;

            if (mid > low && arr[mid] < arr[mid - 1])
                return (mid - 1);

            if (arr[low] >= arr[mid])
                return findPivot(arr, low, mid - 1);

            return findPivot(arr, mid + 1, high);
        }

        /* Standard Binary Search function */
        private int binarySearch(int[] arr, int low,
                                int high, int key)
        {
            if (high < low)
                return -1;

            /* low + (high - low)/2; */
            int mid = (low + high) / 2;

            if (key == arr[mid])
                return mid;
            if (key > arr[mid])
                return binarySearch(arr, (mid + 1), high, key);

            return binarySearch(arr, low, (mid - 1), key);
        }



        // Approach 2: Modified binary search that does search in single pass!!
        // Returns index of key in arr[l..h] 
        // if key is present, otherwise 
        // returns -1 


        /* Improved Solution:
            Approach: Instead of two or more pass of binary search the result can be found in one pass of binary search. The binary search needs to be modified to perform the search. The idea is to create a recursive function that takes l and r as range in input and the key.

            1) Find middle point mid = (l + h)/2
            2) If key is present at middle point, return mid.
            3) Else If arr[l..mid] is sorted
            a) If key to be searched lies in range from arr[l]
               to arr[mid], recur for arr[l..mid].
            b) Else recur for arr[mid+1..h]
            4) Else (arr[mid+1..h] must be sorted)
            a) If key to be searched lies in range from arr[mid+1]
               to arr[h], recur for arr[mid+1..h].
            b) Else recur for arr[l..mid] 
         * 
         */
        public int search(int[] arr, int l, int h,
                          int key)
        {
            if (l > h)
                return -1;

            int mid = (l + h) / 2;

            if (arr[mid] == key)
                return mid;

            /* If arr[l...mid] is sorted */
            if (arr[l] <= arr[mid])
            {

                /* As this subarray is sorted, we  
                can quickly check if key lies in  
                half or other half */
                if (key >= arr[l] && key <= arr[mid])
                    return search(arr, l, mid - 1, key);

                return search(arr, mid + 1, h, key);
            }

            /* If arr[l..mid] is not sorted,  
            then arr[mid... r] must be sorted*/
            if (key >= arr[mid] && key <= arr[h])
                return search(arr, mid + 1, h, key);

            return search(arr, l, mid - 1, key);
        }
    }
}
