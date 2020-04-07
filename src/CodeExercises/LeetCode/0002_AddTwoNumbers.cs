using System.Collections.Generic;

namespace CodeExercises.LeetCode
{
    // 2. https://leetcode.com/problems/add-two-numbers/
    public class AddTwoNumbers
    {
        public ListNode Solve(int[] l1, int[] l2)
        {
            var node1 = ListNode.Create(l1);
            var node2 = ListNode.Create(l2);

            return Solve(node1, node2);
        }

        public ListNode Solve(ListNode l1, ListNode l2)
        {
            var currentL1 = l1;
            var currentL2 = l2;
            var values = new List<int>();

            while (currentL1 != null || currentL2 != null)
            {
                var val1 = currentL1?.val ?? 0;
                var val2 = currentL2?.val ?? 0;
                values.Add(val1 + val2);
                currentL1 = currentL1?.next;
                currentL2 = currentL2?.next;
            }

            ListNode result = null;
            ListNode previousNode = null;
            for (var i = 0; i < values.Count; i++)
            {
                var currentValue = values[i];
                var currentNode = new ListNode(currentValue % 10);
                var exceed = currentValue / 10;
                if (exceed > 0)
                {
                    if (i < values.Count - 1)
                        values[i + 1] += exceed;
                    else
                        values.Add(exceed);
                }

                if (previousNode == null)
                {
                    result = currentNode;
                    previousNode = currentNode;
                    continue;
                }

                previousNode.next = currentNode;
                previousNode = currentNode;
            }

            return result;
        }

        public class ListNode
        {
            public int val;
            public ListNode next;
            public ListNode(int x) { val = x; }

            public static ListNode Create(int[] values)
            {
                var node1 = new ListNode(values[0]);
                for (int i = 1; i < values.Length; i++)
                {
                    var newNode1 = new ListNode(values[i])
                    {
                        next = node1
                    };

                    node1 = newNode1;
                }

                return node1;
            }
        }
    }
}
