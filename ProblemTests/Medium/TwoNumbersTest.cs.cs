using Problems.Medium;
using System.Collections.Generic;

namespace ProblemTests.Medium
{
    [TestFixture]
    public class TwoSumTests
    {
        // Helper method to create a linked list from an array
        private static ListNode CreateList(int[] numbers)
        {
            ListNode dummy = new(0);
            ListNode current = dummy;
            foreach (int num in numbers)
            {
                current.next = new ListNode(num);
                current = current.next;
            }
            return dummy.next!;
        }

        // Helper method to convert a linked list to an array
        private static int[] ListToArray(ListNode node)
        {
            List<int> result = [];
            while (node != null)
            {
                result.Add(node.val);
                node = node.next!;
            }
            return [.. result];
        }

        [Test]
        public void Test_SampleInput1()
        {
            // Input: [2,4,3], [5,6,4]
            ListNode l1 = CreateList([2, 4, 3]);
            ListNode l2 = CreateList([5, 6, 4]);
            int[] expected = new int[] { 7, 0, 8 };

            ListNode result = Leet2.AddTwoNumbers(l1, l2);
            int[] resultArray = ListToArray(result);

            Assert.That(resultArray, Is.EqualTo(expected));
        }

        [Test]
        public void Test_DifferentLengths()
        {
            // Input: [9,9,9,9,9,9,9], [9,9,9,9]
            ListNode l1 = CreateList([9, 9, 9, 9, 9, 9, 9]);
            ListNode l2 = CreateList([9, 9, 9, 9]);
            int[] expected = new int[] { 8, 9, 9, 9, 0, 0, 0, 1 };

            ListNode result = Leet2.AddTwoNumbers(l1, l2);
            int[] resultArray = ListToArray(result);

            Assert.That(resultArray, Is.EqualTo(expected));
        }

        [Test]
        public void Test_ZeroInputs()
        {
            // Input: [0], [0]
            ListNode l1 = CreateList([0]);
            ListNode l2 = CreateList([0]);
            int[] expected = new int[] { 0 };

            ListNode result = Leet2.AddTwoNumbers(l1, l2);
            int[] resultArray = ListToArray(result);

            Assert.That(resultArray, Is.EqualTo(expected));
        }

        [Test]
        public void Test_SingleDigitCarryOver()
        {
            // Input: [5], [5]
            ListNode l1 = CreateList([5]);
            ListNode l2 = CreateList([5]);
            int[] expected = new int[] { 0, 1 };

            ListNode result = Leet2.AddTwoNumbers(l1, l2);
            int[] resultArray = ListToArray(result);

            Assert.That(resultArray, Is.EqualTo(expected));
        }

        [Test]
        public void Test_EmptyInputs()
        {
            // Input: null, null
            ListNode? l1 = null;
            ListNode? l2 = null;

            ListNode result = Leet2.AddTwoNumbers(l1!, l2!);

            Assert.That(result, Is.Null);
        }
    }
}
