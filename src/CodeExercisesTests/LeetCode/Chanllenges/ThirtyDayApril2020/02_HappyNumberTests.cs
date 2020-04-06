using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _02_HappyNumberTests
    {
        [Test]
        [TestCase(19, true)]
        [TestCase(20, false)]
        [TestCase(2, false)]
        [TestCase(1, true)]
        [TestCase(10, true)]
        [TestCase(24, false)]
        [TestCase(1111111, true)]
        public void TestSolution(int input1, bool expectedResult)
        {
            var result = new HappyNumber().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
