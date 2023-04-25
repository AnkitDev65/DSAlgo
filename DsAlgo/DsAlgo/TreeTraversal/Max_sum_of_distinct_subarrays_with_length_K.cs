using System.Collections.Generic;

public class Solution2
    {
        public long MaximumSubarraySum(int[] nums, int k)
        {
            long max_sum = 0;
            long sum = 0;
            if (nums.Length < k)
                return max_sum;

            Dictionary<int, int> subArr = new Dictionary<int, int>();
            int start = 0;
            int end = 0;

            for (; end < k; end++)
            {
                var key = nums[end];
                if (subArr.ContainsKey(key))
                    subArr[key] = subArr[key] + 1;
                else
                    subArr.Add(key, 1);
                sum = sum + key;
            }
            end--;
            max_sum = subArr.Keys.Count == k && sum > max_sum ? sum : max_sum;

            for (; start < nums.Length - k; start++, end++)
            {
                if (nums[start] != nums[end + 1])
                {
                    sum = sum - nums[start] + nums[end + 1];
                    UpdateSubArr(subArr, nums[start], nums[end + 1]);
                    max_sum = subArr.Keys.Count == k && sum > max_sum ? sum : max_sum;
                }
            }
            return max_sum;
        }

        public void UpdateSubArr(Dictionary<int, int> subArr, int prevNum, int nextNum)
        {
            subArr[prevNum] -= 1;
            if (subArr[prevNum] == 0)
                subArr.Remove(prevNum);

            if (subArr.ContainsKey(nextNum))
                subArr[nextNum] += 1;
            else
                subArr.Add(nextNum, 1);
        }
    }
