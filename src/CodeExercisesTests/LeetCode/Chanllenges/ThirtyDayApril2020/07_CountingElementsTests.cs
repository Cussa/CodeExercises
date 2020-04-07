using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _07_CountingElementsTests
    {
        [Test]
        [TestCase(new[] { 1, 2, 3 }, 2)]
        [TestCase(new[] { 1, 1, 3, 3, 5, 5, 7, 7 }, 0)]
        [TestCase(new[] { 1, 3, 2, 3, 5, 0 }, 3)]
        [TestCase(new[] { 1, 1, 2, 2 }, 2)]
        public void TestSolution(int[] input1, int expectedResult)
        {
            var result = new CountingElements().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
