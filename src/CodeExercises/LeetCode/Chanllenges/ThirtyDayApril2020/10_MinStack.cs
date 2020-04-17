using System.Collections.Generic;
using System.Linq;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-10: https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3292/
    public class MinStack
    {
        private Stack<int> stack = new Stack<int>();
        private int numberMin = int.MaxValue;

        /** initialize your data structure here. */
        // Have to keep the same configuration from LeetCode
        // ReSharper disable once EmptyConstructor
        public MinStack()
        {
        }

        public void Push(int x)
        {
            stack.Push(x);
            if (x < numberMin)
                numberMin = x;
        }

        public void Pop()
        {
            stack.Pop();
            numberMin = stack.Count > 0 ? stack.Min() : int.MaxValue;
        }

        public int Top()
        {
            return stack.Peek();
        }

        public int GetMin()
        {
            return numberMin;
        }
    }
}
