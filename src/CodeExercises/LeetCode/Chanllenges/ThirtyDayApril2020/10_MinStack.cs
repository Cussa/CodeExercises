using System.Collections.Generic;
using System.Linq;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-10: https://leetcode.com/explore/featured/card/30-day-leetcoding-challenge/529/week-2/3292/
    public class MinStack
    {
        private readonly Stack<int> _stack = new Stack<int>();
        private int _numberMin = int.MaxValue;

        /** initialize your data structure here. */
        // Have to keep the same configuration from LeetCode
        // ReSharper disable once EmptyConstructor
        public MinStack()
        {
        }

        public void Push(int x)
        {
            _stack.Push(x);
            if (x < _numberMin)
                _numberMin = x;
        }

        public void Pop()
        {
            _stack.Pop();
            _numberMin = _stack.Count > 0 ? _stack.Min() : int.MaxValue;
        }

        public int Top()
        {
            return _stack.Peek();
        }

        public int GetMin()
        {
            return _numberMin;
        }
    }
}
