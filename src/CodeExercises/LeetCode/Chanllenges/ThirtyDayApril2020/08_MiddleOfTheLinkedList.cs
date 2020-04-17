using System;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    // 2020-04-08: https://leetcode.com/explore/challenge/card/30-day-leetcoding-challenge/529/week-2/3290/
    public class MiddleOfTheLinkedList
    {
        public ListNode Resolve(ListNode head)
        {
            var totalNodes = 1;
            var current = head;

            while (current.next != null)
            {
                totalNodes++;
                current = current.next;
            }

            var middleIndex = (int)Math.Ceiling(totalNodes / 2D);
            if (totalNodes % 2 == 0)
                middleIndex++;

            var middleNode = head;
            for (var i = 1; i < middleIndex; i++)
                middleNode = middleNode.next;

            return middleNode;
        }

        public class ListNode
        {
            // Have to keep the same configuration from LeetCode

            // ReSharper disable once InconsistentNaming
            // ReSharper disable once NotAccessedField.Global
            // ReSharper disable once MemberCanBePrivate.Global
            public int val;
            // ReSharper disable once InconsistentNaming
            public ListNode next;
            public ListNode(int x) { val = x; }
        }
    }
}
