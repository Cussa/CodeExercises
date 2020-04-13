using System;
using System.Collections.Generic;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class ContiguousArray
    {
        public int Resolve(int[] nums)
        {
            var maxArray = 0;
            var count = 0;
            var map = new Dictionary<int, int> { { 0, -1 } };
            for (var i = 0; i < nums.Length; i++)
            {
                count += (nums[i] == 1 ? 1 : -1);

                if (map.ContainsKey(count))
                    maxArray = Math.Max(maxArray, i - map[count]);
                else
                    map.Add(count, i);
            }

            return maxArray;
        }
    }
}
