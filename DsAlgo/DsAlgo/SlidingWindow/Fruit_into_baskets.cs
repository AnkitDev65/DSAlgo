using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace DsAlgo.SlidingWindow
{
    public class Solution
    {
        public int TotalFruit(int[] fruits)
        {
            int left = 0;
            int right = 0;
            int k = 2; //basket count
            int max_fruits = 0;
            List<int> basket = new List<int>();

            while (right < fruits.Length)
            {
                var fruit = fruits[right];
                if (!basket.Contains(fruit))
                {
                    //if we have two types of fruit already
                    if (basket.Count == k)
                    {
                        //Empty the basket
                        basket = new List<int>();
                        left = right - 1;
                        int prevFruit = fruits[left];
                        basket.Add(prevFruit);
                        while (prevFruit == fruits[left])
                            left--;

                        left++;
                    }
                    basket.Add(fruit);
                }
                max_fruits = Math.Max(max_fruits, right - left + 1);
                right++;
            }
            return max_fruits;
        }
    }
}
