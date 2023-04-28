using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution5
    {
        public int CharacterReplacement(string s, int k)
        {
            int ans = 0;
            int[] freqmap = new int[26];
            int max_freq = Int32.MinValue;
            int start = 0, end = 0;
            for (; end < s.Length; end++)
            {
                freqmap[s[end]] += 1;
                max_freq = Math.Max(max_freq, freqmap[s[end]]); //maximum same character
                if (end - start + 1 - max_freq > k)  //letters those can be flipped
                {
                    freqmap[s[start]] -= 1;
                    start++;
                }
                ans = end - start + 1;
            }
            return ans;
        }
    }
}
