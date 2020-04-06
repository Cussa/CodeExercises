using System.Collections.Generic;

namespace CodeExercises.LeetCode
{
    // 1. https://leetcode.com/problems/two-sum/
    public class TwoSum
    {
        public int[] Resolve(int[] nums, int target)
        {
            var subList = new Dictionary<int, int>();
            for (var i = 0; i < nums.Length; i++)
            {
                var subValue = target - nums[i];

                if (subList.TryGetValue(subValue, out var index))
                    return new[] { index, i };

                subList.TryAdd(nums[i], i);
            }
            return null;
        }
    }
}
