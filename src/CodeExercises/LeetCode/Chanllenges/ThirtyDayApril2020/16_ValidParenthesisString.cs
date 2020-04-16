using System;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class ValidParenthesisString
    {
        public bool Resolve(string s)
        {
            var lower = 0;
            var higher = 0;
            foreach (var letter in s)
            {
                lower += letter == '(' ? 1 : -1;
                higher += letter != ')' ? 1 : -1;
                if (higher < 0)
                    break;

                lower = Math.Max(lower, 0);
            }

            return lower == 0;
        }
    }
}
