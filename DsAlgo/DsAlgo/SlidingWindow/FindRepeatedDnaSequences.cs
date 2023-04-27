using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution1
    {
        public IList<string> FindRepeatedDnaSequences(string s)
        {
            var repeated = new List<string>();
            var seen = new List<string>();
            for (var i = 0; i <= s.Length - 10; i++)
            {
                var substr = s.Substring(i, 10);
                if (seen.Contains(substr))
                    repeated.Add(substr);
                else
                    seen.Add(substr);
            }

            return repeated;
        }
    }
}
