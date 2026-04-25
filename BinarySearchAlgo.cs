using System;

public class BinarySearchAlgo
{
    public static int BinarySearch(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return -1;
        }

        int left = 0;
        int right = numbers.Length;

        while (left <= right)
        {
            int mid = left + (right - left) / 2;
            
            if (numbers[mid] == target)
            {
                return mid;
            }

        }

    }
}