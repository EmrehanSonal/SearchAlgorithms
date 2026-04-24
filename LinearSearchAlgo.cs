using System;

public class LinearSearchAlgo
{
    public static int LinearSearch(int[] numbers, int target)
    {
        if (numbers == null || numbers.Length == 0)
        {
            return -1;
        }

        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] == target)
            {
                return i;
            }
        }
        return -1;

    }
}