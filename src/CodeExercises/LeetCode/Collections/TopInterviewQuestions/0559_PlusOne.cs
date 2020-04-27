using System.Collections.Generic;

namespace CodeExercises.LeetCode.Collections.TopInterviewQuestions
{
    public class PlusOne
    {
        public int[] Resolve(int[] digits)
        {
            if (digits == null || digits.Length == 0)
                return null;

            var digitsList = new Stack<int>();

            var carry = 1;
            for (var i = digits.Length - 1; i >= 0; i--)
            {
                var current = digits[i] + carry;

                carry = current / 10;
                current %= 10;

                digitsList.Push(current);
            }

            if (carry > 0)
                digitsList.Push(carry);

            return digitsList.ToArray();
        }
    }
}
