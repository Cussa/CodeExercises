namespace CodeExercises.LeetCode
{
    // 7. https://leetcode.com/problems/reverse-integer/
    public class ReverseInteger
    {
        public int Solve(int x)
        {
            var result = 0L;

            while (x != 0)
            {
                var add = x % 10;
                result = result * 10 + add;
                x /= 10;
            }

            if (result < int.MinValue || result > int.MaxValue)
                return 0;

            return (int)result;
        }
    }
}
