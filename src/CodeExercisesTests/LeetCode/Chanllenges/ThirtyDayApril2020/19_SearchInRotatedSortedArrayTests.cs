using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _19_SearchInRotatedSortedArrayTests
    {
        [Test]
        [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 0, 4)]
        [TestCase(new[] { 4, 5, 6, 7, 0, 1, 2 }, 3, -1)]
        public void TestSolution(int[] input1, int input2, int expectedResult)
        {
            var result = new SearchInRotatedSortedArray().Resolve(input1, input2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
