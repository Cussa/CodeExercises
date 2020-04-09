using System.Collections.Generic;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-09: https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3291/
    public class BackspaceStringCompare
    {
        public bool Resolve(string S, string T)
        {
            return RemoveBackspaces(S) == RemoveBackspaces(T);
        }

        private string RemoveBackspaces(string input)
        {
            var output = input;
            var backspaceIndex = input.IndexOf('#');
            while (backspaceIndex > -1)
            {
                var start = -1;
                var remove = 2;
                if (backspaceIndex == 0)
                {
                    start++;
                    remove--;
                }
                output = output.Remove(backspaceIndex + start, remove);

                backspaceIndex = output.IndexOf('#');
            }

            return output;
        }
    }
}
