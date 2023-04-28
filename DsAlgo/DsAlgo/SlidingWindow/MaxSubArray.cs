using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution2
    {
        public int MaxSubArray(int[] nums)
        {
            int sum = 0;

            int max_sum = Int32.MinValue;
            //this is to handle if there are only negative values in array.

            for (int i = 0; i < nums.Length; i++)
            {
                sum += nums[i];
                if (sum < 0)
                {
                    max_sum = Math.Max(max_sum, sum);
                    sum = 0;
                }
                else
                    max_sum = Math.Max(max_sum, sum);
            }
            return max_sum;
        }
    }
}
