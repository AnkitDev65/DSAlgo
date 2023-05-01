using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution7
    {
        public bool CheckInclusion(string s1, string s2)
        {
            int[] freq1 = new int[26];
            int[] freq2 = new int[26];
            int left = 0, right = 0, len = s1.Length;

            if (s2.Length < s1.Length)
                return false;

            for (int i = 0; i < s1.Length; i++)
                freq1[s1[i] - 'a'] += 1;

            for (; right < s2.Length; right++)
            {
                freq2[s2[right] - 'a'] += 1;
                if (right - left + 1 == len)
                {
                    if (IsPermutation(freq1, freq2))
                        return true;
                    freq2[s2[left] - 'a'] -= 1;
                    left++;
                }
            }
            return false;
        }

        public bool IsPermutation(int[] freq1, int[] freq2)
        {
            for (int i = 0; i < 26; i++)
                if (freq1[i] != freq2[i])
                    return false;

            return true;
        }
    }
}
