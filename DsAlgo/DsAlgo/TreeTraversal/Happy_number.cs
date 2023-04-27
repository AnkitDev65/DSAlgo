using System;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.TreeTraversal
{
    public class Solution4
    {
        public bool IsHappy(int n)
        {
            List<int> intArr = new List<int>();
            return IsNumHappy(n, intArr);
        }

        public bool IsNumHappy(int n, List<int> intArr)
        {

            if (n == 0) return false;
            if (n == 1) return true;

            if (intArr.Contains(n))
                return false;
            else
                intArr.Add(n);

            int m = 0;

            while (n != 0)
            {
                m = m + ((n % 10) * (n % 10));
                n = n / 10;
            }
            return IsNumHappy(m, intArr);
        }
    }
}
