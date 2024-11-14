using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class ContainsDuplicatesTest
    {
        [Test]
        public void Test_EmptyArray_ReturnsFalse()
        {
            int[] input = [];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_SingleElementArray_ReturnsFalse()
        {
            int[] input = [1];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_NoDuplicates_ReturnsFalse()
        {
            int[] input = [1, 2, 3, 4, 5];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_WithDuplicates_ReturnsTrue()
        {
            int[] input = [1, 2, 3, 2];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test_AllSameElements_ReturnsTrue()
        {
            int[] input = [5, 5, 5, 5, 5];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test_LargeArrayNoDuplicates_ReturnsFalse()
        {
            int[] input = new int[1000];
            for (int i = 0; i < 1000; i++)
            {
                input[i] = i;
            }

            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_LargeArrayWithDuplicates_ReturnsTrue()
        {
            int[] input = new int[1000];
            for (int i = 0; i < 999; i++)
            {
                input[i] = i;
            }

            input[999] = 500; // Introduce a duplicate
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test_ArrayWithNegativeNumbers_ReturnsTrue()
        {
            int[] input = [-1, -2, -3, -2];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.True);
        }

        [Test]
        public void Test_ArrayWithNegativeNumbersNoDuplicates_ReturnsFalse()
        {
            int[] input = [-1, -2, -3, -4];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.False);
        }

        [Test]
        public void Test_ArrayWithZeroAndPositiveNumbers_ReturnsTrue()
        {
            int[] input = [0, 1, 0];
            bool result = Leet217.ContainsDuplicate(input);
            Assert.That(result, Is.True);
        }
    }
}
