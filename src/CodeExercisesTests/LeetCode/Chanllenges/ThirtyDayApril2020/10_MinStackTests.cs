using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    
    public class _10_MinStackTests
    {
        [Test]
        public void TestSolution()
        {
            var minStack = new MinStack();
            minStack.Push(-2);
            minStack.Push(0);
            minStack.Push(-3);
            
            Assert.AreEqual(-3, minStack.GetMin());

            minStack.Pop();

            Assert.AreEqual(0, minStack.Top());
            Assert.AreEqual(-2, minStack.GetMin());
        }

        //["MinStack","push","push","push",
        //"top","pop","getMin",
        //"pop","getMin","pop",
        //"push","top","getMin",
        //"push","top","getMin",
        //"pop","getMin"]
        
        //[[],[2147483646],[2147483646],[2147483647],[],[],[],[],[],[],[2147483647],[],[],[-2147483648],[],[],[],[]]

        [Test]
        public void TestSolution1()
        {
            var minStack = new MinStack();
            minStack.Push(2147483646);
            minStack.Push(2147483646);
            minStack.Push(2147483647);

            minStack.Top();
            minStack.Pop();
            minStack.GetMin();

            minStack.Pop();
            minStack.GetMin();
            minStack.Pop();

            minStack.Push(2147483647);
            minStack.Top();
            minStack.GetMin();

            minStack.Push(-2147483648);
            minStack.Top();
            minStack.GetMin();

            minStack.Pop();
            minStack.GetMin();
        }
    }
}
