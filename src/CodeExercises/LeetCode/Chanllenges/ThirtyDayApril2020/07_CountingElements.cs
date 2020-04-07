using System.Collections.Generic;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-07: https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/528/week-1/3289/
    public class CountingElements
    {
        public int Resolve(int[] arr)
        {
            var count = 0;
            var visited = new HashSet<int>();
            var baseArray = new HashSet<int>();
            var countedNumbers = new HashSet<int>();
            foreach (var number in arr)
            {
                baseArray.Add(number);
            }

            foreach (var number in arr)
            {
                if (countedNumbers.Contains(number))
                {
                    count++;
                    continue;
                }

                if (visited.Contains(number))
                {
                    continue;
                }

                if (baseArray.Contains(number + 1))
                {
                    count++;
                    countedNumbers.Add(number);
                    visited.Add(number);
                }
            }

            return count;
        }
    }
}
