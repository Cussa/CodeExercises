using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _03_MaximumSubarrayTests
    {
        [Test]
        [TestCase(new[] { -2, 1, -3, 4, -1, 2, 1, -5, 4 }, 6)]
        [TestCase(new[] { -2, 1, -3, 4, -1, 2 }, 5)]
        public void TestSolution(int[] input1, int expectedResult)
        {
            var result = new MaximumSubarray().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
