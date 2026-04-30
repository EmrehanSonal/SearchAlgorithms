using System;

public class ExponentialSearchAlgo
{
    public static int ExponentialSearch(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return -1;
        }
        
        if (numbers[0] == target)
        {
            return 0;
        }

        int n = numbers.Length;
        int i = 1;

        while (i < n && numbers[i] <= target)
        {
            i*=2;
        }

        int left = i / 2;
        int right = Math.Min(i, n - 1);
    }
}