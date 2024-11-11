using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class MergeSortedArrayTest
    {
        private readonly int[] DefaultExpected1 = [1, 2, 2, 3, 5, 6];
        private readonly int[] DefaultExpected2 = [1];
        private readonly int[] DefaultExpected3 = [1];

        [Test]
        public void DefaultTest()
        {
            Assert.That(Leet88.Merge([1, 2, 3, 0, 0, 0], 3, [2, 5, 6], 3), Is.EqualTo(DefaultExpected1));
            Assert.That(Leet88.Merge([1], 1, [], 0), Is.EqualTo(DefaultExpected2));
            Assert.That(Leet88.Merge([0], 0, [1], 1), Is.EqualTo(DefaultExpected3));
        }

        private readonly int[] Expected1 = [10, 10, 10, 10, 10, 10, 10];
        private readonly int[] Expected2 = [1, 2, 3, 4, 5, 6];
        private readonly int[] Expected3 = [1, 2, 2, 3, 4, 4, 10];

        [Test]
        public void MyTest()
        {
            Assert.That(Leet88.Merge([10, 10, 10, 10, 0, 0, 0], 4, [10, 10, 10], 3), Is.EqualTo(Expected1));
            Assert.That(Leet88.Merge([1, 2, 3, 4, 0, 0], 4, [5, 6], 2), Is.EqualTo(Expected2));
            Assert.That(Leet88.Merge([1, 2, 0, 0, 0, 0, 0], 2, [2, 3, 4, 4, 10], 5), Is.EqualTo(Expected3));
        }
    }
}
