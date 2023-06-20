using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    public class TwoSum
    {
        public int[] TwoSumUp(int[] nums, int target)
        {
            var dict = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                dict.Add(i, nums[i]);
            }

            var returnObject = Array.Empty<int>();
            foreach (var item in dict)
            {
                int gap = target - item.Value;
                if (dict.ContainsValue(gap))
                {
                    returnObject = new int[] { item.Key, dict.FirstOrDefault(x => x.Value == gap).Key };
                }
            }

            return returnObject;
        }
    }
}
