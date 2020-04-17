using System.Collections.Generic;
using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using FluentAssertions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _06_GroupAnagramsTests
    {
        static readonly object[] SourceObjects = 
        {
            new object[]
            {
                new[] { "eat", "tea", "tan", "ate", "nat", "bat" },
                new List<IList<string>>
                {
                    new[] {"ate", "eat", "tea"},
                    new[] {"nat", "tan"},
                    new[] {"bat"}
                }
            }
        };

        [Test]
        [TestCaseSource(nameof(SourceObjects))]
        public void TestSolution(string[] input1, IList<IList<string>> expectedResult)
        {
            var result = new GroupAnagrams().Resolve(input1);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
