using System;
using System.Collections.Generic;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-02: https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/528/week-1/3284/
    public class HappyNumber
    {
        public bool Resolve(int n)
        {
            var visited = new HashSet<int>();
            var currentValue = n;
            
            while (currentValue != 1)
            {
                if (visited.Contains(currentValue))
                    return false;

                visited.Add(currentValue);
                var sumResult = 0;

                while (currentValue > 0)
                {
                    var currentNumber = currentValue % 10;
                    currentValue /= 10;
                    sumResult += (int)Math.Pow(currentNumber, 2);
                }
                currentValue = sumResult;
            }

            return true;
        }
    }
}
