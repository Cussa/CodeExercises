﻿using System;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class DiameterOfBinaryTree
    {
        private int depth = 0;

        public int Resolve(TreeNode root)
        {
            GetDepth(root);
            return depth;
        }

        public int GetDepth(TreeNode node)
        {
            if (node == null)
                return 0;

            var edgeLeft = GetDepth(node.left);
            var edgeRight = GetDepth(node.right);

            depth = Math.Max(depth, edgeLeft + edgeRight);

            return Math.Max(edgeLeft, edgeRight) + 1;
        }

        public class TreeNode
        {
            public int val;
            public TreeNode left;
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
