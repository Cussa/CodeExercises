using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _17_NumberOfIslandsTests
    {
        private static readonly object[] SourceObjects =
        {
            new object[]
            {
                new[] { new[] { '1', '1', '1', '1', '0' },
                        new[] { '1', '1', '0', '1', '0' },
                        new[] { '1', '1', '0', '0', '0' },
                        new[] { '0', '0', '0', '0', '0' }
                },
                1
            },
            new object[]
            {
                new[] { new[] { '1', '1', '0', '0', '0' },
                        new[] { '1', '1', '0', '0', '0' },
                        new[] { '0', '0', '1', '0', '0' },
                        new[] { '0', '0', '0', '1', '1' }
                },
                3
            },
            new object[]
            {
                new[] { new[] { '1', '1', '1' },
                        new[] { '0', '1', '0' },
                        new[] { '1', '1', '1' }
                },
                1
            }
        };

        [Test]
        [TestCaseSource(nameof(SourceObjects))]
        public void TestSolution(char[][] input1, int expectedResult)
        {
            var result = new NumberOfIslands().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
