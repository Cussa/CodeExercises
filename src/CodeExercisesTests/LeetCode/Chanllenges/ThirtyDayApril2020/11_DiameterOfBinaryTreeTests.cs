using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _11_DiameterOfBinaryTreeTests
    {
        static readonly object[] sourceObjects =
        {
            new object[]
            {
                new DiameterOfBinaryTree.TreeNode(1)
                {
                    left = new DiameterOfBinaryTree.TreeNode(2)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(4),
                        right = new DiameterOfBinaryTree.TreeNode(5)
                    },
                    right = new DiameterOfBinaryTree.TreeNode(3)
                },
                3
            },
            new object[]
            {
                new DiameterOfBinaryTree.TreeNode(1)
                {
                    left = new DiameterOfBinaryTree.TreeNode(2)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(4),
                        right = new DiameterOfBinaryTree.TreeNode(5)
                        {
                            right = new DiameterOfBinaryTree.TreeNode(6)
                        }
                    },
                    right = new DiameterOfBinaryTree.TreeNode(3)
                },
                4
            },
            new object[]
            {
                new DiameterOfBinaryTree.TreeNode(4)
                {
                    left = new DiameterOfBinaryTree.TreeNode(-7),
                    right = new DiameterOfBinaryTree.TreeNode(-3)
                    {
                        left = new DiameterOfBinaryTree.TreeNode(-9)
                        {
                            left = new DiameterOfBinaryTree.TreeNode(9)
                            {
                                left = new DiameterOfBinaryTree.TreeNode(6)
                                {
                                    left = new DiameterOfBinaryTree.TreeNode(0)
                                    {
                                        right = new DiameterOfBinaryTree.TreeNode(-1)
                                    },
                                    right = new DiameterOfBinaryTree.TreeNode(6)
                                    {
                                        left = new DiameterOfBinaryTree.TreeNode(-4)
                                    }
                                }
                            },
                            right = new DiameterOfBinaryTree.TreeNode(-7)
                            {
                                left = new DiameterOfBinaryTree.TreeNode(-6)
                                {
                                    right = new DiameterOfBinaryTree.TreeNode(5)
                                },
                                right = new DiameterOfBinaryTree.TreeNode(-6)
                                {
                                    right = new DiameterOfBinaryTree.TreeNode(9)
                                    {
                                        right = new DiameterOfBinaryTree.TreeNode(-2)
                                    }
                                }
                            }
                        },
                        right = new DiameterOfBinaryTree.TreeNode(-3)
                        {
                            right = new DiameterOfBinaryTree.TreeNode(-4)
                        }
                    }
                },
                8
            }
        };

        [Test]
        [TestCaseSource(nameof(sourceObjects))]
        public void TestSolution(DiameterOfBinaryTree.TreeNode input1, int expectedResult)
        {
            var result = new DiameterOfBinaryTree().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
