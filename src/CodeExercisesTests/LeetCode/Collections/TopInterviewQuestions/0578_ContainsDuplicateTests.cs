using CodeExercises.LeetCode.Collections.TopInterviewQuestions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Collections.TopInterviewQuestions
{
    public class _0578_ContainsDuplicateTests
    {
        [Test]
        [TestCase(new[] { 1, 2, 3, 1 }, true)]
        [TestCase(new[] { 1, 2, 3, 4 }, false)]
        [TestCase(new[] { 1, 1, 1, 3, 3, 4, 3, 2, 4, 2 }, true)]
        public void TestSolution(int[] input1, bool expectedResult)
        {
            var result = new ContainsDuplicate().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
