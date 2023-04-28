using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution6
    {
        public int LongestOnes(int[] nums, int k)
        {
            int ans = 0;
            int left = 0;
            int zeros = 0;
            for (int right = 0; right < nums.Length; right++)
            {
                if (nums[right] == 0)
                    zeros++;

                if (zeros > k)
                {
                    if (nums[left] == 0)
                        zeros--;
                    left++;
                }
                ans = Math.Max(ans, right - left + 1);
            }
            return ans;
        }
    }
}
