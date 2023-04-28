using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution4
    {
        public int MinSubArrayLen(int target, int[] nums)
        {
            int len = Int32.MaxValue; bool found = false;
            for (int i = 0; i < nums.Length; i++)
            {
                int sum = 0;
                for (int j = i; j < nums.Length; j++)
                {
                    sum += nums[j];
                    if (sum >= target)
                    {
                        len = Math.Min(len, j - i + 1);
                        found = true;
                        break;
                    }
                }
            }
            return found ? len : 0;
        }

        //solution2 optimized
        public int MinSubArrayLen2(int target, int[] nums)
        {
            int len = Int32.MaxValue;
            bool found = false;
            int sum = 0;
            int start = 0, end = 0;

            for (; end < nums.Length; end++)
            {
                sum += nums[end];
                while (sum >= target)
                {
                    //this while loop is to decrease window size as much as we can.. 
                    len = Math.Min(len, end - start + 1);
                    sum -= nums[start];
                    start++;
                    found = true;
                }
            }
            return found ? len : 0;
        }
    }
}
