using Problems.Easy;

namespace ProblemTests.Easy
{
    [TestFixture]
    public class MergeStringsAlternatelyTest
    {
        [Test]
        public void DefaultTest()
        {
            Assert.That(Leet1768.MergeAlternately("abc", "pqr"), Is.EqualTo("apbqcr"));
            Assert.That(Leet1768.MergeAlternately("ab", "pqrs"), Is.EqualTo("apbqrs"));
            Assert.That(Leet1768.MergeAlternately("abcd", "pq"), Is.EqualTo("apbqcd"));
        }
        [Test]
        public void MyTest()
        {
            Assert.That(Leet1768.MergeAlternately("acefg", "bd"), Is.EqualTo("abcdefg"));
            Assert.That(Leet1768.MergeAlternately("acegi", "bdfhj"), Is.EqualTo("abcdefghij"));
            Assert.That(Leet1768.MergeAlternately("acegi", "bdfhjk"), Is.EqualTo("abcdefghijk"));
        }
    }
}
