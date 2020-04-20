using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _18_MinimumPathSumTests
    {
        private static readonly object[] SourceObjects =
        {
            new object[]
            {
                new[] { new[] { 1, 3, 1 },
                        new[] { 1, 5, 1 },
                        new[] { 4, 2, 1 }
                },
                7
            }
        };

        [Test]
        [TestCaseSource(nameof(SourceObjects))]
        public void TestSolution(int[][] input1, int expectedResult)
        {
            var result = new MinimumPathSum().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
