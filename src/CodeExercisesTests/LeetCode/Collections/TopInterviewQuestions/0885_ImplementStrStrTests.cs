using CodeExercises.LeetCode.Collections.TopInterviewQuestions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Collections.TopInterviewQuestions
{
    public class _0885_ImplementStrStrTests
    {
        [Test]
        [TestCase("hello", "ll", 2)]
        [TestCase("aaaaa", "ba", -1)]
        [TestCase("hello", "", 0)]
        public void TestSolution(string input1, string input2, int expectedResult)
        {
            var result = new ImplementStrStr().Resolve(input1, input2);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
