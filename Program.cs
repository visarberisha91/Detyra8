using System;

namespace Detyra8
{
    class Program
    {
        static int maxSubArraySum(int[] a)
        {
            int size = a.Length;
            int max_so_far = int.MinValue,
                max_ending_here = 0;

            for (int i = 0; i < size; i++)
            {
                max_ending_here = max_ending_here + a[i];

                if (max_so_far < max_ending_here)
                    max_so_far = max_ending_here;

                if (max_ending_here < 0)
                    max_ending_here = 0;
            }

            return max_so_far;
        }
        static void Main(string[] args)
        {
            int[] a = { 5, 3, 6, -6, 9, 12, -5, 3, 5, 8, -1 };
            Console.Write("Maximum contiguous sum is " +
                                    maxSubArraySum(a));
        }
    }
}
