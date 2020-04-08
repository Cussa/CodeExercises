using CodeExercises.LeetCode;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode
{
    public class _0007_ReverseIntegerTests
    {
        [Test]
        [TestCase(123,321)]
        [TestCase(-123, -321)]
        [TestCase(120, 21)]
        [TestCase(1534236469, 0)]
        public void TestSolution(int number, int expectedResult)
        {
            var result = new ReverseInteger().Solve(number);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
