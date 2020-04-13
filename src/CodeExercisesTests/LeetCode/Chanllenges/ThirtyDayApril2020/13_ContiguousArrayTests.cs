using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _13_ContigousArrayTests
    {
        [Test]
        [TestCase(new[] { 0, 1, 0 }, 2)]
        [TestCase(new[] { 0, 1 }, 2)]
        [TestCase(new[] { 0, 0, 1, 1 }, 4)]
        [TestCase(new[] { 0, 1, 1, 0, 1, 1, 1, 0 }, 4)]
        public void TestSolution(int[] input1, int expectedResult)
        {
            var result = new ContiguousArray().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
