using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _15_ProducOfArrayExceptSelfTests
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 4 }, new[] { 24, 12, 8, 6 })]
        [TestCase(new[] { 4, 5, 1, 8, 2, 10, 6 }, new[] { 4800, 3840, 19200, 2400, 9600, 1920, 3200 })]
        public void TestSolution(int[] input1, int[] expectedResult)
        {
            var result = new ProducOfArrayExceptSelf().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
