using CodeExercises.LeetCode;
using FluentAssertions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode
{
    public class _0002_AddTwoNumbersTests
    {
        [Test]
        [TestCase(new[] { 2, 4, 3 }, new[] { 5, 6, 4 }, new[] { 8, 0, 7 })]
        [TestCase(new[] { 5 }, new[] { 5 }, new[] { 1, 0 })]
        [TestCase(new[] { 1, 8 }, new[] { 0 }, new[] { 1, 8 })]
        public void TestSolution(int[] node1, int[] node2, int[] expectedResult)
        {
            var result = new AddTwoNumbers().Solve(node1, node2);
            var nodeResult = AddTwoNumbers.ListNode.Create(expectedResult);
            result.Should().BeEquivalentTo(nodeResult);
        }
    }
}
