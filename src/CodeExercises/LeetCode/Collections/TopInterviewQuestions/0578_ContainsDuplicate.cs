using System.Collections.Generic;

namespace CodeExercises.LeetCode.Collections.TopInterviewQuestions
{
    // https://leetcode.com/explore/featured/card/top-interview-questions-easy/92/array/578/
    public class ContainsDuplicate
    {
        public bool Resolve(int[] nums)
        {
            if (nums.Length < 2)
                return false;

            var set = new HashSet<int>();
            foreach (var t in nums)
            {
                if (set.Contains(t))
                    return true;

                set.Add(t);
            }

            return false;
        }
    }
}
