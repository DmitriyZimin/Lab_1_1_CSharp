using System;

namespace Lab_1_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] nums = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };

            int c;

            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] % 2 == 0)
                {
                    c = nums[i];
                    Console.WriteLine(c);
                }
            }

        }
    }
}