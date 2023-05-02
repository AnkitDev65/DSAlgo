using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution8
    {
        public IList<int> FindAnagrams(string s, string p)
        {
            int[] freq1 = new int[26];
            int[] freq2 = new int[26];
            IList<int> output = new List<int>();
            int left = 0, right = 0, len = p.Length;

            if (s.Length < len)
                return output;

            for (int i = 0; i < p.Length; i++)
                freq1[p[i] - 'a'] += 1;

            for (; right < s.Length; right++)
            {
                freq2[s[right] - 'a'] += 1;
                if (right - left + 1 == len)
                {
                    if (IsPermutation(freq1, freq2))
                        output.Add(left);
                    freq2[s[left] - 'a'] -= 1;
                    left++;
                }
            }
            return output;
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
