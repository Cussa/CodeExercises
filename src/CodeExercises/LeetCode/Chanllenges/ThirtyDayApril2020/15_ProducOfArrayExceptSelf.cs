namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class ProducOfArrayExceptSelf
    {
        public int[] Resolve(int[] nums)
        {
            var answer = new int[nums.Length];
            answer[0] = 1;

            for (int i = 1; i < nums.Length; i++)
            {
                answer[i] = nums[i - 1] * answer[i - 1];
            }

            var right = 1;
            for (int i = nums.Length-1; i >= 0; i--)
            {
                answer[i] = answer[i] * right;
                right *= nums[i];
            }

            return answer;
        }
    }
}
