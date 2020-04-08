namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-03: https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/528/week-1/3285/
    public class MaximumSubarray
    {
        public int Resolve(int[] nums)
        {
            var sum = 0;
            var maxSum = nums[0];

            foreach (var number in nums)
            {
                sum += number;
                if (number > sum)
                    sum = number;
                if (sum > maxSum)
                    maxSum = sum;
            }

            return maxSum;
        }
    }
}
