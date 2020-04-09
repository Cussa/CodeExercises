using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _09_BackspaceStringCompareTests
    {
        [Test]
        [TestCase("ab#c", "ad#c", true)]
        [TestCase("ab##", "c#d#", true)]
        [TestCase("a##c", "#a#c", true)]
        [TestCase("a#c", "b", false)]
        public void TestSolution(string input1, string input2, bool expectedResult)
        {
            var result = new BackspaceStringCompare().Resolve(input1, input2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
