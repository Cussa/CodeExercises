using System;

namespace CodeExercises.LeetCode.Collections.TopInterviewQuestions
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-medium/113/math/820/
    public class DivideTwoIntegers
    {
        public int Resolve(int dividend, int divisor)
        {
            try
            {
                return dividend / divisor;
            }
            catch (OverflowException)
            {
                return int.MaxValue;
            }
        }
    }
}
