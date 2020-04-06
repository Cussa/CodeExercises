using CodeExercises.LeetCode;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode
{
    public class _0001_TwoSumTests
    {
        [Test]
        [TestCase(new[] { 2, 7, 11, 15 }, 9, new[] { 0, 1 })]
        [TestCase(new[] { 2, 11, 7, 15 }, 9, new[] { 0, 2 })]
        [TestCase(new[] { 2, 11, 15, 7 }, 9, new[] { 0, 3 })]
        [TestCase(new[] { 42, 2, 7, 15 }, 9, new[] { 1, 2 })]
        [TestCase(new[] { 230,863,916,585,981,404,316,785,88,12,70,435,384,778,887,755,740,337,86,92,325,422,815,650,920,125,277,336,221,847,168,23,677,61,400,136,874,363,394,199,863,997,794,587,124,321,212,957,764,173,314,422,927,783,930,282,306,506,44,926,691,568,68,730,933,737,531,180,414,751,28,546,60,371,493,370,527,387,43,541,13,457,328,227,652,365,430,803,59,858,538,427,583,368,375,173,809,896,370,789}, 542, new[] { 28, 45 })] 
        public void TestSolution(int[] nums, int target, int[] expectedResult)
        {
            var result = new TwoSum().Resolve(nums, target);
            Assert.AreEqual(expectedResult, result);
        }
    }
}
