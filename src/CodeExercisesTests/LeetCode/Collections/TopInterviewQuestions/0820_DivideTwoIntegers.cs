using CodeExercises.LeetCode.Collections.TopInterviewQuestions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Collections.TopInterviewQuestions
{
    public class _0820_DivideTwoIntegers
    {
        [Test]
        [TestCase(10, 3, 3)]
        [TestCase(7, -3, -2)]
        [TestCase(-2147483648, -1, 2147483647)]
        public void TestSolution(int input1, int input2, int expectedResult)
        {
            var result = new DivideTwoIntegers().Resolve(input1, input2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
