using System;

public class InterpolationSearchAlgo
{
    public static int InterpolationSearch(int[] numbers, int target)
    {

        if (numbers == null || numbers.Length == 0)
        {
            return -1;
        }

        int low  = 0;
        int high = numbers.Length -1;

        while (low <= high && numbers[low] <= target && numbers[high] >= target)
        {
            if (numbers[low] == numbers[high])
            {
                if (numbers[low] == target)
                {
                    return low;
                }else
                {
                    return -1;
                }
            }
        }        

        int pos = low + ((target - numbers[low])*(high - low))
                        /(numbers[high] - numbers[low]);

        if (numbers[pos] == target)
        {
            return pos;
        }
        if (numbers[pos] < target)
        {
            low = pos + 1;
        }else
        {
            high = pos - 1;
        }

        return -1;

    }
}