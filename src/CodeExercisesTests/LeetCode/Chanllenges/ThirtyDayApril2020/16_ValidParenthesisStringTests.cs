using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _16_ValidParenthesisStringTests
    {
        [Test]
        [TestCase("()", true)]
        [TestCase("(*)", true)]
        [TestCase("(*))", true)]
        [TestCase(")", false)]
        [TestCase("())", false)]
        [TestCase("(*()", true)]
        [TestCase(")(", false)]
        public void TestSolution(string input1, bool expectedResult)
        {
            var result = new ValidParenthesisString().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
