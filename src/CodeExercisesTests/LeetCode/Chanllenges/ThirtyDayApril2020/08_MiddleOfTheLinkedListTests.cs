using CodeExercises.LeetCode.Chanllenges.ThirtyDayApril2020;
using FluentAssertions;
using NUnit.Framework;

namespace CodeExercisesTests.LeetCode.Chanllenges.ThirtyDayApril2020
{
    public class _08_MiddleOfTheLinkedListTests
    {
        [Test]
        public void TestSolution001()
        {
            var input = new MiddleOfTheLinkedList.ListNode(1)
            {
                next = new MiddleOfTheLinkedList.ListNode(2)
                {
                    next = new MiddleOfTheLinkedList.ListNode(3)
                    {
                        next = new MiddleOfTheLinkedList.ListNode(4)
                        {
                            next = new MiddleOfTheLinkedList.ListNode(5)
                        }
                    }
                }
            };

            var expectedResult = new MiddleOfTheLinkedList.ListNode(3)
            {
                next = new MiddleOfTheLinkedList.ListNode(4)
                {
                    next = new MiddleOfTheLinkedList.ListNode(5)
                }
            };

            var result = new MiddleOfTheLinkedList().Resolve(input);
            result.Should().BeEquivalentTo(expectedResult);
        }

        [Test]
        public void TestSolution002()
        {
            var input = new MiddleOfTheLinkedList.ListNode(1)
            {
                next = new MiddleOfTheLinkedList.ListNode(2)
                {
                    next = new MiddleOfTheLinkedList.ListNode(3)
                    {
                        next = new MiddleOfTheLinkedList.ListNode(4)
                        {
                            next = new MiddleOfTheLinkedList.ListNode(5)
                            {
                                next = new MiddleOfTheLinkedList.ListNode(6)
                            }
                        }
                    }
                }
            };

            var expectedResult = new MiddleOfTheLinkedList.ListNode(4)
            {
                next = new MiddleOfTheLinkedList.ListNode(5)
                {
                    next = new MiddleOfTheLinkedList.ListNode(6)
                }
            };

            var result = new MiddleOfTheLinkedList().Resolve(input);
            result.Should().BeEquivalentTo(expectedResult);
        }
    }
}
