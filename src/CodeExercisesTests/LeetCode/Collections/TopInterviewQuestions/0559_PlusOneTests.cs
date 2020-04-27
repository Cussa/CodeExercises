using CodeExercises.LeetCode.Collections.TopInterviewQuestions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Collections.TopInterviewQuestions
{
    public class _0559_PlusOneTests
    {
        [Test]
        [TestCase(new[] { 9 }, new[] { 1, 0 })]
        [TestCase(new[] { 9, 9 }, new[] { 1, 0, 0 })]
        [TestCase(new[] { 1, 2, 3, 1 }, new[] { 1, 2, 3, 2 })]
        [TestCase(new[] { 1, 2, 3, 9 }, new[] { 1, 2, 4, 0 })]
        public void TestSolution(int[] input1, int[] expectedResult)
        {
            var result = new PlusOne().Resolve(input1);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
