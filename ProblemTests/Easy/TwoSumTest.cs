using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class TwoSumTest
    {
        private static readonly int[] DefaultExpected1 = [0, 1];
        private static readonly int[] DefaultExpected2 = [1, 2];
        private static readonly int[] DefaultExpected3 = [0, 1];

        [Test]
        public void DefaultTest()
        {
            Assert.That(Leet1.TwoSum([2, 7, 11, 15], 9), Is.EqualTo(DefaultExpected1));
            Assert.That(Leet1.TwoSum([3, 2, 4], 6), Is.EqualTo(DefaultExpected2));
            Assert.That(Leet1.TwoSum([3, 3], 6), Is.EqualTo(DefaultExpected3));
        }

        private static readonly int[] MyExpected1 = [2, 3];
        private static readonly int[] MyExpected2 = [3, 5];
        private static readonly int[] MyExpected3 = [0, 1];

        [Test]
        public void MyTest()
        {
            Assert.That(Leet1.TwoSum([1, 2, 3, 4, 5, 6], 7), Is.EqualTo(MyExpected1));
            Assert.That(Leet1.TwoSum([1, 2, 3, 4, 5, 6], 10), Is.EqualTo(MyExpected2));
            Assert.That(Leet1.TwoSum([1, 2], 3), Is.EqualTo(MyExpected3));
        }
    }
}
