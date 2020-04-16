using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _14_PerformStringShiftsTests
    {
        private static readonly object[] sourceObjects =
        {
            new object[]
            {
                "abc",
                new[] { new[] {0,1}, new[] {1,2} },
                "cab"
            },
            new object[]
            {
                "abcdefg",
                new[] { new[] { 1, 1 }, new[] { 1, 1 }, new[] { 0, 2 }, new[] { 1, 3 } },
                "efgabcd"
            },
            new object[]
            {
                "wpdhhcj",
                new[] { new[] { 0, 7 }, new[] { 1, 7 }, new[] { 1, 0 }, new[] { 1, 3 }, new[] { 0, 3 }, new[] { 0, 6 }, new[] { 1, 2 } },
                "hcjwpdh"
            }
        };

        [Test]
        [TestCaseSource(nameof(sourceObjects))]
        public void TestSolution(string input1, int[][] input2, string expectedResult)
        {
            var result = new PerformStringShifts().Resolve(input1, input2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
