using Problems.Medium;

namespace Problems.Tests.Medium
{
    [TestFixture]
    public class MergeIntervalsTests
    {
        [Test]
        public void TestExample1()
        {
            int[][] intervals =
            [
                [1, 3],
                [2, 6],
                [8, 10],
                [15, 18]
            ];
            int[][] expected =
            [
                [1, 6],
                [8, 10],
                [15, 18]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestExample2()
        {
            int[][] intervals =
            [
                [1, 4],
                [4, 5]
            ];
            int[][] expected =
            [
                [1, 5]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestNoOverlap()
        {
            int[][] intervals =
            [
                [1, 2],
                [3, 4],
                [5, 6]
            ];
            int[][] expected =
            [
                [1, 2],
                [3, 4],
                [5, 6]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestCompleteOverlap()
        {
            int[][] intervals =
            [
                [1, 10],
                [2, 5],
                [3, 7],
                [8, 10]
            ];
            int[][] expected =
            [
                [1, 10]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestSingleInterval()
        {
            int[][] intervals =
            [
                [1, 3]
            ];
            int[][] expected =
            [
                [1, 3]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestEmptyIntervals()
        {
            int[][] intervals = [];
            int[][] expected = [];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestIdenticalIntervals()
        {
            int[][] intervals =
            [
                [1, 4],
                [1, 4],
                [1, 4]
            ];
            int[][] expected =
            [
                [1, 4]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestSubIntervals()
        {
            int[][] intervals =
            [
                [1, 5],
                [2, 3]
            ];
            int[][] expected =
            [
                [1, 5]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestTouchingIntervals()
        {
            int[][] intervals =
            [
                [1, 2],
                [2, 3],
                [3, 4]
            ];
            int[][] expected =
            [
                [1, 4]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }

        [Test]
        public void TestLargeIntervals()
        {
            int[][] intervals =
            [
                [1, 10000],
                [5000, 100000]
            ];
            int[][] expected =
            [
                [1, 100000]
            ];
            var result = MergeIntervals.Merge(intervals);
            CollectionAssert.AreEqual(expected, result);
        }
    }
}
