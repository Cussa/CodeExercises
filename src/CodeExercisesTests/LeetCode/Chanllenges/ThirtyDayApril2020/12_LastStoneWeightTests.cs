using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _12_LastStoneWeightTests
    {
        [Test]
        [TestCase(new[] { 2, 7, 4, 1, 8, 1 }, 1)]
        //[TestCase(new[] { 1, 1, 3, 3, 5, 5, 7, 7 }, 0)]
        //[TestCase(new[] { 1, 3, 2, 3, 5, 0 }, 3)]
        //[TestCase(new[] { 1, 1, 2, 2 }, 2)]
        public void TestSolution(int[] input1, int expectedResult)
        {
            var result = new LastStoneWeight().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
