using System;

namespace CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class DiameterOfBinaryTree
    {
        private int _depth;

        public int Resolve(TreeNode root)
        {
            GetDepth(root);
            return _depth;
        }

        public int GetDepth(TreeNode node)
        {
            if (node == null)
                return 0;

            var edgeLeft = GetDepth(node.left);
            var edgeRight = GetDepth(node.right);

            _depth = Math.Max(_depth, edgeLeft + edgeRight);

            return Math.Max(edgeLeft, edgeRight) + 1;
        }

        public class TreeNode
        {
            // Have to keep same configuration from LeetCode

            // ReSharper disable once InconsistentNaming
            // ReSharper disable once NotAccessedField.Global
            // ReSharper disable once MemberCanBePrivate.Global
            public int val;
            // ReSharper disable once InconsistentNaming
            public TreeNode left;
            // ReSharper disable once InconsistentNaming
            public TreeNode right;
            public TreeNode(int x) { val = x; }
        }
    }
}
