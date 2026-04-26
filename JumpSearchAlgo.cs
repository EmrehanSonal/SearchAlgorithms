using System;

public class JumpSearchAlgo
{
    public static int JumpSearch(int[] numbers, int target)
    {
        
        if (numbers == null || numbers.Length == 0)
        {
            return -1;
        }

        int n = numbers.Length;
        int step =(int)Math.Sqrt(n);
        int prev = 0;

        while (prev < n && numbers[Math.Min(step, n) -1] < target)
        {
            prev = step;

            step =+ (int)Math.Sqrt(n);

            if (prev >= n)
            {
                return -1;
            }
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