using System;

namespace CodeExercises.LeetCode.Collections.TopInterviewQuestions
{
    // https://leetcode.com/explore/interview/card/top-interview-questions-easy/127/strings/885/
    public class ImplementStrStr
    {
        public int Resolve(string haystack, string needle)
        {
            return string.IsNullOrEmpty(needle) ? 0 : haystack.IndexOf(needle, StringComparison.InvariantCulture);
        }
    }
}
